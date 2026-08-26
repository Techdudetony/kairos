using Kairos.Application.FocusIntentions;
using Kairos.Domain;
using NSubstitute;

namespace Kairos.Desktop.Tests;

public class FocusSessionPersistenceCoordinatorTests
{
    private static FocusSession CreateSession() =>
        FocusSession.Start(FocusIntention.Create("Write report", TimeSpan.FromMinutes(30)));

    [Fact]
    public void Store_changes_before_start_do_not_persist()
    {
        var store = new ActiveFocusSessionStore();
        var repository = Substitute.For<IFocusSessionRepository>();
        var coordinator = new FocusSessionPersistenceCoordinator(store, repository);

        store.Set(CreateSession());

        repository.DidNotReceive().Save(Arg.Any<FocusSession>());
    }

    [Fact]
    public void Store_set_after_start_calls_repository_save()
    {
        var store = new ActiveFocusSessionStore();
        var repository = Substitute.For<IFocusSessionRepository>();
        var coordinator = new FocusSessionPersistenceCoordinator(store, repository);
        coordinator.Start();

        var session = CreateSession();
        store.Set(session);

        repository.Received(1).Save(session);
    }

    [Fact]
    public void Multiple_set_calls_each_persist_the_new_session()
    {
        var store = new ActiveFocusSessionStore();
        var repository = Substitute.For<IFocusSessionRepository>();
        var coordinator = new FocusSessionPersistenceCoordinator(store, repository);
        coordinator.Start();

        var firstSession = CreateSession();
        var secondSession = FocusSession.Start(FocusIntention.Create("Review PR", TimeSpan.FromMinutes(15)));
        store.Set(firstSession);
        store.Set(secondSession);

        repository.Received(1).Save(firstSession);
        repository.Received(1).Save(secondSession);
    }

    [Fact]
    public void Calling_start_twice_does_not_cause_a_double_save()
    {
        var store = new ActiveFocusSessionStore();
        var repository = Substitute.For<IFocusSessionRepository>();
        var coordinator = new FocusSessionPersistenceCoordinator(store, repository);
        coordinator.Start();
        coordinator.Start();

        var session = CreateSession();
        store.Set(session);

        repository.Received(1).Save(session);
    }
}
