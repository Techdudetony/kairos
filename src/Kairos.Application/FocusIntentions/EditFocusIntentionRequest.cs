using Kairos.Domain;

namespace Kairos.Application.FocusIntentions;

public sealed record EditFocusIntentionRequest(
    FocusSession CurrentSession,
    string TaskName,
    string? TaskContext = null,
    IReadOnlyList<string>? ExpectedApplications = null);
