using Kairos.Application.FocusIntentions;
using Kairos.Domain;
using Shouldly;

namespace Kairos.Application.Tests;

public class ActiveFocusSessionStoreTests
{
    [Fact]
    public void Set_updates_current()
    {
        var store = new ActiveFocusSessionStore();
        var intention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(25));
        var session = FocusSession.Start(intention);

        store.Set(session);

        store.Current.ShouldBe(session);
    }

    [Fact]
    public void Set_raises_current_changed()
    {
        var store = new ActiveFocusSessionStore();
        var intention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(25));
        var session = FocusSession.Start(intention);
        var eventRaised = false;

        store.CurrentChanged += () => eventRaised = true;
        store.Set(session);

        eventRaised.ShouldBeTrue();
    }
}
