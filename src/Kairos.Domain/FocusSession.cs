namespace Kairos.Domain;

public sealed record FocusSession
{
    public FocusIntention Intention { get; }
    public FocusSessionState State { get; }

    private FocusSession(FocusIntention intention, FocusSessionState state)
    {
        Intention = intention;
        State = state;
    }

    public static FocusSession Start(FocusIntention intention)
    {
        return new FocusSession(intention, FocusSessionState.Companion);
    }

    public FocusSession WithIntention(FocusIntention updatedIntention)
    {
        ArgumentNullException.ThrowIfNull(updatedIntention);

        return new FocusSession(updatedIntention, State);
    }
}
