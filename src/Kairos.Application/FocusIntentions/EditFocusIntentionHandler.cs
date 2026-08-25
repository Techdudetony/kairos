using Kairos.Application.Common;
using Kairos.Domain;

namespace Kairos.Application.FocusIntentions;

public sealed class EditFocusIntentionHandler
{
    public Result<FocusSession> Handle(EditFocusIntentionRequest request)
    {
        FocusIntention updatedIntention;

        try
        {
            updatedIntention = FocusIntention.Create(
                request.TaskName,
                request.CurrentSession.Intention.PlannedDuration,
                request.TaskContext,
                request.ExpectedApplications);
        }
        catch (ArgumentException ex)
        {
            return Result<FocusSession>.Failure(ex.Message);
        }

        var updatedSession = request.CurrentSession.WithIntention(updatedIntention);

        return Result<FocusSession>.Success(updatedSession);
    }
}
