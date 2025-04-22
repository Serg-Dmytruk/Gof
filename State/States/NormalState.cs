using State.Contexts;

namespace State.States;

public sealed class NormalState : ICharacterState
{
    public void HandleDamage(Character character, int amount)
    {
        character.ModifyHealth(-amount);
        
        if(character.Health < 30)
            character.SetState(new InjuredState());
    }

    public void HandlePowerUp(Character character)
    {
        character.SetPowerUp(true);
        character.SetState(new PoweredState());
    }

    public void HandleUpdate(Character character)
    {
        character.ModifyHealth(1);
    }
}