namespace Decorator;

public sealed class BluePaintVolvoDecorator(IVovloES90Model car) : VolvoDecorator(car)
{
    public override decimal GetPrice()
    {
        return Car.GetPrice() + 500M;
    }

    public override string GetDescription()
    {
        return $"{Car.GetDescription()}, Blue Paint";
    }
}