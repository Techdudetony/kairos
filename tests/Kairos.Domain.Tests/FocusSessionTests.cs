using Shouldly;

namespace Kairos.Domain.Tests;

public class FocusSessionTests
{
    [Fact]
    public void Start_from_valid_intention_enters_companion_state()
    {
        var intention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(30));

        var session = FocusSession.Start(intention);

        session.State.ShouldBe(FocusSessionState.Companion);
        session.Intention.ShouldBe(intention);
    }
}
