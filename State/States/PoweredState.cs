using State.Contexts;

namespace State.States;

public sealed class PoweredState : ICharacterState
{
    private int _powerUpDuration = 10;
    public void HandleDamage(Character character, int amount)
    {
        character.ModifyHealth(-(amount / 2));
    }

    public void HandlePowerUp(Character character)
    {
        _powerUpDuration = 10;
    }

    public void HandleUpdate(Character character)
    {
        _powerUpDuration--;

        if (_powerUpDuration > 1)
            return;
        
        character.SetPowerUp(false);
        character.SetState(new NormalState());
    }
}