namespace Kairos.Application.FocusIntentions;

public sealed record CreateFocusIntentionRequest(
    string TaskName,
    TimeSpan PlannedDuration,
    string? TaskContext = null,
    IReadOnlyList<string>? ExpectedApplications = null);
