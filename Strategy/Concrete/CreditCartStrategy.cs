namespace Strategy.Concrete;

public class CreditCartStrategy(string Name, string CardNumber) : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"You paid credit card ${amount}");
    }
}