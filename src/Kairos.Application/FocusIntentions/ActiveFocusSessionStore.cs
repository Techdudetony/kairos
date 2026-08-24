using Kairos.Domain;

namespace Kairos.Application.FocusIntentions;

public sealed class ActiveFocusSessionStore
{
    public FocusSession? Current { get; private set; }

    public event Action? CurrentChanged;

    public void Set(FocusSession session)
    {
        ArgumentNullException.ThrowIfNull(session);

        Current = session;
        CurrentChanged?.Invoke();
    }
}
