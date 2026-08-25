using System.Text.Json;
using Kairos.Application.FocusIntentions;
using Kairos.Domain;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;

namespace Kairos.Infrastructure.FocusIntentions;

public sealed class SqliteFocusSessionRepository : IFocusSessionRepository
{
    private readonly ILogger<SqliteFocusSessionRepository> _logger;
    private readonly string _databasePath;

    public SqliteFocusSessionRepository(ILogger<SqliteFocusSessionRepository> logger)
        : this(logger, ResolveDefaultDatabasePath())
    {
    }

    public SqliteFocusSessionRepository(ILogger<SqliteFocusSessionRepository> logger, string databasePath)
    {
        _logger = logger;
        _databasePath = databasePath;
    }

    public FocusSession? Load()
    {
        try
        {
            EnsureDatabaseReady();

            using var connection = OpenConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                SELECT TaskName, PlannedDurationTicks, TaskContext, ExpectedApplicationsJson, State
                FROM ActiveFocusSession
                WHERE Id = 1;
                """;

            using var reader = command.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            var taskName = reader.GetString(0);
            var plannedDurationTicks = reader.GetInt64(1);
            var taskContext = reader.IsDBNull(2) ? null : reader.GetString(2);
            var expectedApplicationsJson = reader.GetString(3);
            var stateText = reader.GetString(4);

            if (!Enum.TryParse<FocusSessionState>(stateText, out var state) || !Enum.IsDefined(state))
            {
                _logger.LogWarning("Persisted focus session state {StateText} is not recognized; discarding.", stateText);
                return null;
            }

            var expectedApplications = JsonSerializer.Deserialize<List<string>>(expectedApplicationsJson);

            if (expectedApplications is null)
            {
                _logger.LogWarning("Persisted expected applications for the active focus session could not be read; discarding.");
                return null;
            }

            var intention = FocusIntention.Create(
                taskName,
                new TimeSpan(plannedDurationTicks),
                taskContext,
                expectedApplications);

            return FocusSession.Restore(intention, state);
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Failed to load persisted focus session; continuing without one.");
            return null;
        }
    }

    public void Save(FocusSession session)
    {
        try
        {
            EnsureDatabaseReady();

            using var connection = OpenConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                INSERT INTO ActiveFocusSession
                    (Id, TaskName, PlannedDurationTicks, TaskContext, ExpectedApplicationsJson, State)
                VALUES
                    (1, @TaskName, @PlannedDurationTicks, @TaskContext, @ExpectedApplicationsJson, @State)
                ON CONFLICT(Id) DO UPDATE SET
                    TaskName = excluded.TaskName,
                    PlannedDurationTicks = excluded.PlannedDurationTicks,
                    TaskContext = excluded.TaskContext,
                    ExpectedApplicationsJson = excluded.ExpectedApplicationsJson,
                    State = excluded.State;
                """;

            command.Parameters.AddWithValue("@TaskName", session.Intention.TaskName);
            command.Parameters.AddWithValue("@PlannedDurationTicks", session.Intention.PlannedDuration.Ticks);
            command.Parameters.AddWithValue("@TaskContext", (object?)session.Intention.TaskContext ?? DBNull.Value);
            command.Parameters.AddWithValue("@ExpectedApplicationsJson", JsonSerializer.Serialize(session.Intention.ExpectedApplications));
            command.Parameters.AddWithValue("@State", session.State.ToString());

            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Failed to persist the active focus session.");
        }
    }

    private void EnsureDatabaseReady()
    {
        var directory = Path.GetDirectoryName(_databasePath);

        if (!string.IsNullOrEmpty(directory))
        {
            Directory.CreateDirectory(directory);
        }

        using var connection = OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = """
            CREATE TABLE IF NOT EXISTS ActiveFocusSession
            (
                Id INTEGER PRIMARY KEY CHECK (Id = 1),
                TaskName TEXT NOT NULL,
                PlannedDurationTicks INTEGER NOT NULL,
                TaskContext TEXT NULL,
                ExpectedApplicationsJson TEXT NOT NULL,
                State TEXT NOT NULL
            );
            """;
        command.ExecuteNonQuery();
    }

    private SqliteConnection OpenConnection()
    {
        var connection = new SqliteConnection($"Data Source={_databasePath};Pooling=False");
        connection.Open();
        return connection;
    }

    private static string ResolveDefaultDatabasePath()
    {
        return Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Kairos",
            "data",
            "kairos.db");
    }
}
