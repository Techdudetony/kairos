using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kairos.Application.FocusIntentions;
using Kairos.Desktop.Common;

namespace Kairos.Desktop.ViewModels;

public partial class EditFocusIntentionViewModel : ViewModelBase
{
    private readonly EditFocusIntentionHandler _handler;
    private readonly ActiveFocusSessionStore _store;

    [ObservableProperty]
    private string _taskName = string.Empty;

    [ObservableProperty]
    private string? _taskContext;

    [ObservableProperty]
    private string? _expectedApplicationsInput;

    public ObservableCollection<string> ValidationMessages { get; } = new();

    public EditFocusIntentionViewModel(EditFocusIntentionHandler handler, ActiveFocusSessionStore store)
    {
        _handler = handler;
        _store = store;
    }

    public void LoadCurrentIntention()
    {
        ValidationMessages.Clear();

        var currentIntention = _store.Current?.Intention;

        TaskName = currentIntention?.TaskName ?? string.Empty;
        TaskContext = currentIntention?.TaskContext;
        ExpectedApplicationsInput = currentIntention is null
            ? null
            : string.Join(", ", currentIntention.ExpectedApplications);
    }

    [RelayCommand]
    private void Save()
    {
        ValidationMessages.Clear();

        var currentSession = _store.Current;

        if (currentSession is null)
        {
            ValidationMessages.Add("There is no active intention to edit.");
            return;
        }

        var expectedApplications = ExpectedApplicationsParser.Parse(ExpectedApplicationsInput);

        var request = new EditFocusIntentionRequest(
            currentSession,
            TaskName,
            TaskContext,
            expectedApplications);

        var result = _handler.Handle(request);

        if (result.IsSuccess)
        {
            _store.Set(result.Value!);
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
