using Kairos.Application.Common;
using Kairos.Domain;

namespace Kairos.Application.FocusIntentions;

public sealed class CreateFocusIntentionHandler
{
    public Result<FocusSession> Handle(CreateFocusIntentionRequest request)
    {
        FocusIntention intention;

        try
        {
            intention = FocusIntention.Create(
                request.TaskName,
                request.PlannedDuration,
                request.TaskContext,
                request.ExpectedApplications);
        }
        catch (ArgumentException ex)
        {
            return Result<FocusSession>.Failure(ex.Message);
        }

        var session = FocusSession.Start(intention);

        return Result<FocusSession>.Success(session);
    }
}
