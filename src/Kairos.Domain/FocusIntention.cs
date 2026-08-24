namespace Kairos.Domain;

public sealed record FocusIntention
{
    public string TaskName { get; }
    public TimeSpan PlannedDuration { get; }
    public string? TaskContext { get; }
    public IReadOnlyList<string> ExpectedApplications { get; }

    private FocusIntention(
        string taskName,
        TimeSpan plannedDuration,
        string? taskContext,
        IReadOnlyList<string> expectedApplications)
    {
        TaskName = taskName;
        PlannedDuration = plannedDuration;
        TaskContext = taskContext;
        ExpectedApplications = expectedApplications;
    }

    public static FocusIntention Create(
        string taskName,
        TimeSpan plannedDuration,
        string? taskContext = null,
        IReadOnlyList<string>? expectedApplications = null)
    {
        if (string.IsNullOrWhiteSpace(taskName))
        {
            throw new ArgumentException("Task name must not be empty.", nameof(taskName));
        }

        if (plannedDuration <= TimeSpan.Zero)
        {
            throw new ArgumentException("Planned duration must be greater than zero.", nameof(plannedDuration));
        }

        return new FocusIntention(
            taskName,
            plannedDuration,
            taskContext,
            expectedApplications ?? Array.Empty<string>());
    }
}
