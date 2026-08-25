using Kairos.Application.FocusIntentions;
using Kairos.Domain;
using Shouldly;

namespace Kairos.Application.Tests;

public class EditFocusIntentionHandlerTests
{
    private readonly EditFocusIntentionHandler _handler = new();

    private static FocusSession CreateOriginalSession() =>
        FocusSession.Start(FocusIntention.Create(
            "Write report",
            TimeSpan.FromMinutes(30),
            "Original context",
            new[] { "WINWORD.EXE" }));

    [Fact]
    public void Valid_edit_returns_a_new_focus_session()
    {
        var originalSession = CreateOriginalSession();
        var request = new EditFocusIntentionRequest(originalSession, "Review PR");

        var result = _handler.Handle(request);

        result.IsSuccess.ShouldBeTrue();
        result.Value.ShouldNotBe(originalSession);
    }

    [Fact]
    public void Valid_edit_returns_a_new_focus_intention()
    {
        var originalSession = CreateOriginalSession();
        var request = new EditFocusIntentionRequest(originalSession, "Review PR");

        var result = _handler.Handle(request);

        result.Value!.Intention.ShouldNotBe(originalSession.Intention);
    }

    [Fact]
    public void Valid_edit_changes_task_name()
    {
        var originalSession = CreateOriginalSession();
        var request = new EditFocusIntentionRequest(originalSession, "Review PR");

        var result = _handler.Handle(request);

        result.Value!.Intention.TaskName.ShouldBe("Review PR");
    }

    [Fact]
    public void Valid_edit_changes_task_context()
    {
        var originalSession = CreateOriginalSession();
        var request = new EditFocusIntentionRequest(originalSession, "Review PR", "Updated context");

        var result = _handler.Handle(request);

        result.Value!.Intention.TaskContext.ShouldBe("Updated context");
    }

    [Fact]
    public void Valid_edit_changes_expected_applications()
    {
        var originalSession = CreateOriginalSession();
        var request = new EditFocusIntentionRequest(
            originalSession,
            "Review PR",
            ExpectedApplications: new[] { "chrome.exe", "code.exe" });

        var result = _handler.Handle(request);

        result.Value!.Intention.ExpectedApplications.ShouldBe(new[] { "chrome.exe", "code.exe" });
    }

    [Fact]
    public void Valid_edit_leaves_planned_duration_exactly_unchanged()
    {
        var originalSession = CreateOriginalSession();
        var request = new EditFocusIntentionRequest(originalSession, "Review PR");

        var result = _handler.Handle(request);

        result.Value!.Intention.PlannedDuration.ShouldBe(originalSession.Intention.PlannedDuration);
    }

    [Fact]
    public void Valid_edit_leaves_session_state_exactly_unchanged()
    {
        var originalSession = CreateOriginalSession();
        var request = new EditFocusIntentionRequest(originalSession, "Review PR");

        var result = _handler.Handle(request);

        result.Value!.State.ShouldBe(originalSession.State);
    }

    [Fact]
    public void Blank_task_name_returns_failure_and_no_session()
    {
        var originalSession = CreateOriginalSession();
        var request = new EditFocusIntentionRequest(originalSession, "   ");

        var result = _handler.Handle(request);

        result.IsSuccess.ShouldBeFalse();
        result.Value.ShouldBeNull();
        result.Errors.ShouldNotBeEmpty();
    }
}
