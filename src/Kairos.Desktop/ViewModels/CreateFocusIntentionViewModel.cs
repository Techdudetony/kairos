using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kairos.Application.FocusIntentions;
using Kairos.Domain;

namespace Kairos.Desktop.ViewModels;

public partial class CreateFocusIntentionViewModel : ViewModelBase
{
    private readonly CreateFocusIntentionHandler _handler;
    private readonly ActiveFocusSessionStore _activeFocusSessionStore;

    [ObservableProperty]
    private string _taskName = string.Empty;

    [ObservableProperty]
    private int _plannedDurationMinutes = 25;

    [ObservableProperty]
    private string? _taskContext;

    [ObservableProperty]
    private string? _expectedApplicationsInput;

    [ObservableProperty]
    private FocusSession? _activeSession;

    public ObservableCollection<string> ValidationMessages { get; } = new();

    public CreateFocusIntentionViewModel(
        CreateFocusIntentionHandler handler,
        ActiveFocusSessionStore activeFocusSessionStore)
    {
        _handler = handler;
        _activeFocusSessionStore = activeFocusSessionStore;
    }

    [RelayCommand]
    private void Start()
    {
        ValidationMessages.Clear();
        ActiveSession = null;

        var expectedApplications = (ExpectedApplicationsInput ?? string.Empty)
            .Split(',')
            .Select(app => app.Trim())
            .Where(app => app.Length > 0)
            .ToList();

        var request = new CreateFocusIntentionRequest(
            TaskName,
            TimeSpan.FromMinutes(PlannedDurationMinutes),
            TaskContext,
            expectedApplications);

        var result = _handler.Handle(request);

        if (result.IsSuccess)
        {
            ActiveSession = result.Value;
            _activeFocusSessionStore.Set(result.Value!);
        }
        else
        {
            foreach (var error in result.Errors)
            {
                ValidationMessages.Add(error);
            }
        }
    }
}
