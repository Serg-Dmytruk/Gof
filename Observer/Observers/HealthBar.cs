using Observer.Subjects;

namespace Observer.Observers;

public class HealthBar(Player player) : IGameObserver
{
    public void Update() => Console.WriteLine($"Health: {player.GetHealth()}");
}