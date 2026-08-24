using Kairos.Application.FocusIntentions;
using Kairos.Domain;
using Shouldly;

namespace Kairos.Application.Tests;

public class CreateFocusIntentionHandlerTests
{
    private readonly CreateFocusIntentionHandler _handler = new();

    [Fact]
    public void Valid_request_returns_successful_result_with_companion_session()
    {
        var request = new CreateFocusIntentionRequest("Write report", TimeSpan.FromMinutes(30));

        var result = _handler.Handle(request);

        result.IsSuccess.ShouldBeTrue();
        result.Value.ShouldNotBeNull();
        result.Value!.State.ShouldBe(FocusSessionState.Companion);
        result.Value.Intention.TaskName.ShouldBe("Write report");
    }

    [Fact]
    public void Invalid_request_returns_failure_result_with_validation_message()
    {
        var request = new CreateFocusIntentionRequest("", TimeSpan.FromMinutes(30));

        var result = _handler.Handle(request);

        result.IsSuccess.ShouldBeFalse();
        result.Value.ShouldBeNull();
        result.Errors.ShouldNotBeEmpty();
    }
}
