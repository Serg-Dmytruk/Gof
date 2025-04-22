using Observer.Observers;

namespace Observer.Subjects;

public interface IGameSubject
{
    void Attach(IGameObserver observer);
    void Detach(IGameObserver observer);
    void Notify();
}