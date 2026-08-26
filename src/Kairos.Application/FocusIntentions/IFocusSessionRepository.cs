using Kairos.Domain;

namespace Kairos.Application.FocusIntentions;

public interface IFocusSessionRepository
{
    FocusSession? Load();

    void Save(FocusSession session);
}
