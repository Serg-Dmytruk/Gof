using State.Contexts;

namespace State.States;

public sealed class InjuredState : ICharacterState
{
    public void HandleDamage(Character character, int amount)
    {
        character.ModifyHealth(-(amount * 2));
    }

    public void HandlePowerUp(Character character)
    {
        character.ModifyHealth(50);
        character.SetState(new NormalState());
    }

    public void HandleUpdate(Character character)
    {
       character.ModifyHealth(2);

       if (character.Health >= 30)
       {
           character.SetState(new NormalState());
       }
    }
}