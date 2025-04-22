namespace Strategy.Concrete;

public class BankTransferStrategy : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
       Console.WriteLine("You pay using bank transfer");
    }
}