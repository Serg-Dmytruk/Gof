using Observer.Subjects;

namespace Observer.Observers;

public sealed class GameOverScreen(Player player) : IGameObserver
{
    public void Update()
    {
        if (player.GetHealth() == 0)
        {
            Console.WriteLine("Game Over");
        }
    }
}