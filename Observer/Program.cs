using Observer.Observers;
using Observer.Subjects;

var player = new Player();

player.Attach(new HealthBar(player));
player.Attach(new ScoreBar(player));
player.Attach(new GameOverScreen(player));


player.SetState(100, 0);
player.SetState(90, 10);
player.SetState(80, 15);
player.SetState(0, 10);