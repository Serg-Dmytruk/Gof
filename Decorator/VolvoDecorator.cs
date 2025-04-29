namespace Decorator;

public abstract class VolvoDecorator(IVovloES90Model car) : IVovloES90Model
{
    protected readonly IVovloES90Model Car = car;
    
    public virtual decimal GetPrice()
    {
       return Car.GetPrice();
    }

    public virtual string GetDescription()
    {
        return Car.GetDescription();
    }

    public virtual double GetRange()
    {
        return Car.GetRange();
    }
}