namespace Decorator;

public sealed class LongRangeVolvoDecorator(IVovloES90Model car) : VolvoDecorator(car) 
{
    public override decimal GetPrice()
    {
        return base.GetPrice() + 3500M;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Long-range";
    }

    public override double GetRange()
    {
        return base.GetRange() + 90D;
    }
}