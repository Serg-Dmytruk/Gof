using Observer.Subjects;

namespace Observer.Observers;

public sealed class ScoreBar(Player player) : IGameObserver
{
    public void Update() => Console.WriteLine($"Score: {player.GetScore()}");
}