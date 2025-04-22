using Observer.Observers;

namespace Observer.Subjects;

public sealed class Player : IGameSubject
{
    private readonly List<IGameObserver> _observers = [];

    private int _health;
    private int _score;

    public void SetState(int health, int score)
    {
        _health = health;
        _score = score;
        Notify();
    }

    public int GetHealth() => _health;
    public int GetScore() => _score;
    public void Attach(IGameObserver observer) => _observers.Add(observer);
    public void Detach(IGameObserver observer) => _observers.Remove(observer);

    public void Notify()
    {
        foreach (var observer in _observers)
            observer.Update();
    }
}