using Avalonia.Controls;
using Avalonia.Interactivity;
using Kairos.Application.FocusIntentions;
using Kairos.Desktop.ViewModels;

namespace Kairos.Desktop.Views;

public partial class ActiveIntentionWindow : Window
{
    private EditFocusIntentionHandler? _editHandler;
    private ActiveFocusSessionStore? _store;

    public ActiveIntentionWindow()
    {
        InitializeComponent();
    }

    public void Initialize(EditFocusIntentionHandler editHandler, ActiveFocusSessionStore store)
    {
        _editHandler = editHandler;
        _store = store;
    }

    private void OnEditClick(object? sender, RoutedEventArgs e)
    {
        if (_editHandler is null || _store is null)
        {
            return;
        }

        var editViewModel = new EditFocusIntentionViewModel(_editHandler, _store);
        editViewModel.LoadCurrentIntention();

        var editWindow = new EditFocusIntentionWindow
        {
            DataContext = editViewModel,
        };
        editWindow.Show();
    }
}
