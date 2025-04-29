namespace Decorator;

public sealed class BaseVovloModel : IVovloES90Model
{
    public decimal GetPrice()
    {
        return 25000M;
    }

    public string GetDescription()
    {
        return "Volvo ES90 Model";
    }

    public double GetRange()
    {
        return 272D;
    }
}