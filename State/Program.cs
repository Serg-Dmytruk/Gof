using State.Contexts;
using State.States;

var character = new Character(new NormalState());

Console.WriteLine($"Initial\nHealth: {character.Health}\nPowerUp {character.HasPowerUp}");

character.TakeDamage(30);
Console.WriteLine($"After damage 30 \nHealth: {character.Health}\nPowerUp {character.HasPowerUp}");

character.CollectPowerUp();
Console.WriteLine($"After collect power up\nHealth: {character.Health}\nPowerUp {character.HasPowerUp}");

character.TakeDamage(50);
Console.WriteLine($"After damage 50 \nHealth: {character.Health}\nPowerUp {character.HasPowerUp}");

for (var i = 0; i < 10; i++)
{
    character.Update();
}

Console.WriteLine($"After 10 ticks\nHealth: {character.Health}\nPowerUp {character.HasPowerUp}");

character.TakeDamage(34);
Console.WriteLine($"After damage 30 \nHealth: {character.Health}\nPowerUp {character.HasPowerUp}");