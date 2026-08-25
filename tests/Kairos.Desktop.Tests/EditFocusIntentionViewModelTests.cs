using Kairos.Application.FocusIntentions;
using Kairos.Desktop.ViewModels;
using Kairos.Domain;
using Shouldly;

namespace Kairos.Desktop.Tests;

public class EditFocusIntentionViewModelTests
{
    private static (EditFocusIntentionViewModel ViewModel, ActiveFocusSessionStore Store) CreateViewModel()
    {
        var store = new ActiveFocusSessionStore();
        var viewModel = new EditFocusIntentionViewModel(new EditFocusIntentionHandler(), store);
        return (viewModel, store);
    }

    private static FocusSession CreateOriginalSession() =>
        FocusSession.Start(FocusIntention.Create(
            "Write report",
            TimeSpan.FromMinutes(30),
            "Original context",
            new[] { "WINWORD.EXE" }));

    [Fact]
    public void LoadCurrentIntention_populates_fields_from_the_store()
    {
        var (viewModel, store) = CreateViewModel();
        var session = CreateOriginalSession();
        store.Set(session);

        viewModel.LoadCurrentIntention();

        viewModel.TaskName.ShouldBe("Write report");
        viewModel.TaskContext.ShouldBe("Original context");
        viewModel.ExpectedApplicationsInput.ShouldBe("WINWORD.EXE");
    }

    [Fact]
    public void LoadCurrentIntention_discards_stale_unsaved_edits_on_reopen()
    {
        var (viewModel, store) = CreateViewModel();
        store.Set(CreateOriginalSession());
        viewModel.LoadCurrentIntention();

        viewModel.TaskName = "Some unsaved edit the user typed but never saved";

        viewModel.LoadCurrentIntention();

        viewModel.TaskName.ShouldBe("Write report");
    }

    [Fact]
    public void Successful_save_replaces_the_store_current_session()
    {
        var (viewModel, store) = CreateViewModel();
        store.Set(CreateOriginalSession());
        viewModel.LoadCurrentIntention();
        viewModel.TaskName = "Review PR";

        viewModel.SaveCommand.Execute(null);

        store.Current!.Intention.TaskName.ShouldBe("Review PR");
    }

    [Fact]
    public void Failed_save_leaves_the_store_current_session_unchanged()
    {
        var (viewModel, store) = CreateViewModel();
        var originalSession = CreateOriginalSession();
        store.Set(originalSession);
        viewModel.LoadCurrentIntention();
        viewModel.TaskName = "   ";

        viewModel.SaveCommand.Execute(null);

        store.Current.ShouldBe(originalSession);
    }

    [Fact]
    public void Blank_task_name_produces_a_validation_message_without_altering_active_state()
    {
        var (viewModel, store) = CreateViewModel();
        store.Set(CreateOriginalSession());
        viewModel.LoadCurrentIntention();
        viewModel.TaskName = "   ";

        viewModel.SaveCommand.Execute(null);

        viewModel.ValidationMessages.ShouldNotBeEmpty();
    }
}
