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

    [Fact]
    public void WithIntention_replaces_intention_and_preserves_state()
    {
        var originalIntention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(30));
        var session = FocusSession.Start(originalIntention);
        var updatedIntention = FocusIntention.Create("Review PR", TimeSpan.FromMinutes(30));

        var updatedSession = session.WithIntention(updatedIntention);

        updatedSession.Intention.ShouldBe(updatedIntention);
        updatedSession.State.ShouldBe(session.State);
    }

    [Fact]
    public void WithIntention_rejects_null()
    {
        var intention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(30));
        var session = FocusSession.Start(intention);

        Should.Throw<ArgumentNullException>(() => session.WithIntention(null!));
    }
}
