using Kairos.Application.FocusIntentions;

namespace Kairos.Desktop;

public sealed class FocusSessionPersistenceCoordinator
{
    private readonly ActiveFocusSessionStore _store;
    private readonly IFocusSessionRepository _repository;
    private bool _started;

    public FocusSessionPersistenceCoordinator(ActiveFocusSessionStore store, IFocusSessionRepository repository)
    {
        _store = store;
        _repository = repository;
    }

    public void Start()
    {
        if (_started)
        {
            return;
        }

        _started = true;
        _store.CurrentChanged += OnCurrentChanged;
    }

    private void OnCurrentChanged()
    {
        if (_store.Current is not null)
        {
            _repository.Save(_store.Current);
        }
    }
}
