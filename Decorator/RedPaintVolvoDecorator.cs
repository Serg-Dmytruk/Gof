namespace Decorator;

public sealed class RedPaintVolvoDecorator(IVovloES90Model car) : VolvoDecorator(car)
{
    public override decimal GetPrice()
    {
        return Car.GetPrice() + 1000M;
    }

    public override string GetDescription()
    {
        return $"{Car.GetDescription()}, Red Paint";
    }
}