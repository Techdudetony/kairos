using Kairos.Application.FocusIntentions;
using Kairos.Desktop.ViewModels;
using Kairos.Domain;
using Shouldly;

namespace Kairos.Desktop.Tests;

public class CreateFocusIntentionViewModelTests
{
    private static CreateFocusIntentionViewModel CreateViewModel() =>
        new(new CreateFocusIntentionHandler());

    [Fact]
    public void Start_with_valid_input_maps_fields_into_active_session()
    {
        var viewModel = CreateViewModel();
        viewModel.TaskName = "Write report";
        viewModel.PlannedDurationMinutes = 45;
        viewModel.TaskContext = "Quarterly summary";
        viewModel.ExpectedApplicationsInput = "WINWORD.EXE, notepad.exe";

        viewModel.StartCommand.Execute(null);

        viewModel.ActiveSession.ShouldNotBeNull();
        viewModel.ActiveSession!.Intention.TaskName.ShouldBe("Write report");
        viewModel.ActiveSession.Intention.PlannedDuration.ShouldBe(TimeSpan.FromMinutes(45));
        viewModel.ActiveSession.Intention.TaskContext.ShouldBe("Quarterly summary");
        viewModel.ActiveSession.Intention.ExpectedApplications.ShouldBe(new[] { "WINWORD.EXE", "notepad.exe" });
    }

    [Fact]
    public void Start_with_valid_input_enters_companion_state()
    {
        var viewModel = CreateViewModel();
        viewModel.TaskName = "Write report";
        viewModel.PlannedDurationMinutes = 25;

        viewModel.StartCommand.Execute(null);

        viewModel.ActiveSession!.State.ShouldBe(FocusSessionState.Companion);
    }

    [Fact]
    public void Start_with_blank_task_name_surfaces_validation_message()
    {
        var viewModel = CreateViewModel();
        viewModel.TaskName = string.Empty;
        viewModel.PlannedDurationMinutes = 25;

        viewModel.StartCommand.Execute(null);

        viewModel.ActiveSession.ShouldBeNull();
        viewModel.ValidationMessages.ShouldNotBeEmpty();
    }

    [Fact]
    public void Start_parses_comma_separated_applications_trimming_and_dropping_blanks()
    {
        var viewModel = CreateViewModel();
        viewModel.TaskName = "Write report";
        viewModel.PlannedDurationMinutes = 25;
        viewModel.ExpectedApplicationsInput = " WINWORD.EXE ,, notepad.exe , ";

        viewModel.StartCommand.Execute(null);

        viewModel.ActiveSession!.Intention.ExpectedApplications.ShouldBe(new[] { "WINWORD.EXE", "notepad.exe" });
    }

    [Fact]
    public void Start_with_no_optional_fields_still_succeeds()
    {
        var viewModel = CreateViewModel();
        viewModel.TaskName = "Write report";
        viewModel.PlannedDurationMinutes = 25;

        viewModel.StartCommand.Execute(null);

        viewModel.ActiveSession.ShouldNotBeNull();
        viewModel.ActiveSession!.Intention.TaskContext.ShouldBeNull();
        viewModel.ActiveSession.Intention.ExpectedApplications.ShouldBeEmpty();
    }
}
