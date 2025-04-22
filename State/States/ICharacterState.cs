using State.Contexts;

namespace State.States;

public interface ICharacterState
{
    void HandleDamage(Character character, int amount);
    void HandlePowerUp(Character character);
    void HandleUpdate(Character character);
}