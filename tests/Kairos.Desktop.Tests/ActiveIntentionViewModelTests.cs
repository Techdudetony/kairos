using Kairos.Application.FocusIntentions;
using Kairos.Desktop.ViewModels;
using Kairos.Domain;
using Shouldly;

namespace Kairos.Desktop.Tests;

public class ActiveIntentionViewModelTests
{
    [Fact]
    public void Reflects_the_stores_current_session_on_construction()
    {
        var store = new ActiveFocusSessionStore();
        var intention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(25));
        var session = FocusSession.Start(intention);
        store.Set(session);

        var viewModel = new ActiveIntentionViewModel(store);

        viewModel.ActiveSession.ShouldBe(session);
    }

    [Fact]
    public void Updates_automatically_when_the_store_changes()
    {
        var store = new ActiveFocusSessionStore();
        var viewModel = new ActiveIntentionViewModel(store);
        var intention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(25));
        var session = FocusSession.Start(intention);

        store.Set(session);

        viewModel.ActiveSession.ShouldBe(session);
    }

    [Fact]
    public void A_subsequent_store_update_refreshes_the_bound_intention_without_a_refresh_call()
    {
        var store = new ActiveFocusSessionStore();
        var viewModel = new ActiveIntentionViewModel(store);
        var firstIntention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(25));
        var firstSession = FocusSession.Start(firstIntention);
        store.Set(firstSession);

        var secondIntention = FocusIntention.Create("Review PR", TimeSpan.FromMinutes(15));
        var secondSession = FocusSession.Start(secondIntention);
        store.Set(secondSession);

        viewModel.ActiveSession.ShouldBe(secondSession);
    }

    [Fact]
    public void Reflects_an_edited_intention_after_a_successful_edit()
    {
        var store = new ActiveFocusSessionStore();
        var viewModel = new ActiveIntentionViewModel(store);
        var originalSession = FocusSession.Start(FocusIntention.Create("Write report", TimeSpan.FromMinutes(30)));
        store.Set(originalSession);

        var editHandler = new EditFocusIntentionHandler();
        var editRequest = new EditFocusIntentionRequest(store.Current!, "Review PR");
        var editResult = editHandler.Handle(editRequest);
        store.Set(editResult.Value!);

        viewModel.ActiveSession!.Intention.TaskName.ShouldBe("Review PR");
    }
}
