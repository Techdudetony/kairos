using CommunityToolkit.Mvvm.ComponentModel;
using Kairos.Application.FocusIntentions;
using Kairos.Domain;

namespace Kairos.Desktop.ViewModels;

public partial class ActiveIntentionViewModel : ViewModelBase
{
    private readonly ActiveFocusSessionStore _store;

    [ObservableProperty]
    private FocusSession? _activeSession;

    public ActiveIntentionViewModel(ActiveFocusSessionStore store)
    {
        _store = store;
        _activeSession = store.Current;
        _store.CurrentChanged += OnCurrentChanged;
    }

    private void OnCurrentChanged()
    {
        ActiveSession = _store.Current;
    }
}
