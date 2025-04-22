namespace Strategy.Concrete;

public class PayPallStrategy : IPaymentStrategy
{
public void Pay(decimal amount)
{
    Console.WriteLine("You pay using pay pall");
}
}