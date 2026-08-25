using Kairos.Domain;
using Kairos.Infrastructure.FocusIntentions;
using Microsoft.Extensions.Logging.Abstractions;
using Shouldly;

namespace Kairos.Infrastructure.Tests;

public class SqliteFocusSessionRepositoryTests : IDisposable
{
    private readonly string _databasePath;
    private readonly SqliteFocusSessionRepository _repository;

    private void OverwriteStateColumn(string value)
    {
        using var connection = new Microsoft.Data.Sqlite.SqliteConnection($"Data Source={_databasePath};Pooling=False");
        connection.Open();
        using var command = connection.CreateCommand();
        command.CommandText = "UPDATE ActiveFocusSession SET State = @State WHERE Id = 1;";
        command.Parameters.AddWithValue("@State", value);
        command.ExecuteNonQuery();
    }

    private void OverwriteExpectedApplicationsColumn(string value)
    {
        using var connection = new Microsoft.Data.Sqlite.SqliteConnection($"Data Source={_databasePath};Pooling=False");
        connection.Open();
        using var command = connection.CreateCommand();
        command.CommandText = "UPDATE ActiveFocusSession SET ExpectedApplicationsJson = @Json WHERE Id = 1;";
        command.Parameters.AddWithValue("@Json", value);
        command.ExecuteNonQuery();
    }

    public SqliteFocusSessionRepositoryTests()
    {
        _databasePath = Path.Combine(Path.GetTempPath(), $"kairos-test-{Guid.NewGuid()}.db");
        _repository = new SqliteFocusSessionRepository(NullLogger<SqliteFocusSessionRepository>.Instance, _databasePath);
    }

    public void Dispose()
    {
        if (File.Exists(_databasePath))
        {
            File.Delete(_databasePath);
        }
    }

    [Fact]
    public void Load_against_a_fresh_database_returns_null()
    {
        var result = _repository.Load();

        result.ShouldBeNull();
    }

    [Fact]
    public void Save_then_load_round_trips_every_field()
    {
        var intention = FocusIntention.Create(
            "Write report",
            TimeSpan.FromMinutes(45),
            "Quarterly summary",
            new[] { "WINWORD.EXE", "notepad.exe" });
        var session = FocusSession.Start(intention);

        _repository.Save(session);
        var loaded = _repository.Load();

        loaded.ShouldNotBeNull();
        loaded!.Intention.TaskName.ShouldBe("Write report");
        loaded.Intention.TaskContext.ShouldBe("Quarterly summary");
        loaded.Intention.ExpectedApplications.ShouldBe(new[] { "WINWORD.EXE", "notepad.exe" });
        loaded.State.ShouldBe(FocusSessionState.Companion);
    }

    [Fact]
    public void Planned_duration_round_trips_exactly()
    {
        var oddDuration = TimeSpan.FromSeconds(1837.123456);
        var intention = FocusIntention.Create("Write report", oddDuration);
        var session = FocusSession.Start(intention);

        _repository.Save(session);
        var loaded = _repository.Load();

        loaded!.Intention.PlannedDuration.ShouldBe(oddDuration);
    }

    [Fact]
    public void Session_state_round_trips_exactly()
    {
        var intention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(30));
        var session = FocusSession.Start(intention);

        _repository.Save(session);
        var loaded = _repository.Load();

        loaded!.State.ShouldBe(FocusSessionState.Companion);
    }

    [Fact]
    public void Expected_applications_round_trip_exactly()
    {
        var intention = FocusIntention.Create(
            "Write report",
            TimeSpan.FromMinutes(30),
            expectedApplications: new[] { "chrome.exe", "code.exe", "slack.exe" });
        var session = FocusSession.Start(intention);

        _repository.Save(session);
        var loaded = _repository.Load();

        loaded!.Intention.ExpectedApplications.ShouldBe(new[] { "chrome.exe", "code.exe", "slack.exe" });
    }

    [Fact]
    public void Expected_applications_containing_commas_round_trip_exactly()
    {
        var intention = FocusIntention.Create(
            "Write report",
            TimeSpan.FromMinutes(30),
            expectedApplications: new[] { "Notes, Personal.exe", "Report v1, final.exe" });
        var session = FocusSession.Start(intention);

        _repository.Save(session);
        var loaded = _repository.Load();

        loaded!.Intention.ExpectedApplications.ShouldBe(new[] { "Notes, Personal.exe", "Report v1, final.exe" });
    }

    [Fact]
    public void Second_save_replaces_the_single_stored_session()
    {
        var firstIntention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(30));
        _repository.Save(FocusSession.Start(firstIntention));

        var secondIntention = FocusIntention.Create("Review PR", TimeSpan.FromMinutes(15));
        _repository.Save(FocusSession.Start(secondIntention));

        var loaded = _repository.Load();

        loaded!.Intention.TaskName.ShouldBe("Review PR");
    }

    [Fact]
    public void Load_against_a_corrupt_file_returns_null_without_throwing()
    {
        File.WriteAllText(_databasePath, "this is not a valid sqlite database file");

        var result = _repository.Load();

        result.ShouldBeNull();
    }

    [Fact]
    public void Save_against_an_inaccessible_path_does_not_throw()
    {
        var invalidPath = Path.Combine(Path.GetTempPath(), "kairos-test-invalid", "???", "kairos.db");
        var repository = new SqliteFocusSessionRepository(NullLogger<SqliteFocusSessionRepository>.Instance, invalidPath);
        var intention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(30));

        Should.NotThrow(() => repository.Save(FocusSession.Start(intention)));
    }

    [Fact]
    public void Load_with_an_undefined_numeric_state_returns_null_without_throwing()
    {
        var intention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(30));
        _repository.Save(FocusSession.Start(intention));
        OverwriteStateColumn("999");

        var result = _repository.Load();

        result.ShouldBeNull();
    }

    [Fact]
    public void Load_with_json_null_expected_applications_returns_null_without_throwing()
    {
        var intention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(30));
        _repository.Save(FocusSession.Start(intention));
        OverwriteExpectedApplicationsColumn("null");

        var result = _repository.Load();

        result.ShouldBeNull();
    }
}
