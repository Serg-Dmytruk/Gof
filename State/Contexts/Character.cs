using State.States;

namespace State.Contexts;

public sealed class Character(ICharacterState initialState)
{
    public int Health { get; private set; } = 100;
    public bool HasPowerUp { get; private set; }
    
    private ICharacterState _state = initialState;
    
    public void SetState(ICharacterState state)
    {
        _state = state;
    }
    
    public void TakeDamage(int damage)
    {
        _state.HandleDamage(this, damage);   
    }

    public void CollectPowerUp()
    {
       _state.HandlePowerUp(this);
    }

    public void Update()
    {
        _state.HandleUpdate(this);
    }

    public void ModifyHealth(int amount)
    {
        Health = Math.Clamp(Health + amount, 0, 100);
    }

    public void SetPowerUp(bool hasPowerUp)
    {
        HasPowerUp = hasPowerUp;
    }
}