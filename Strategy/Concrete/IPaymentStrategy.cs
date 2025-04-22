namespace Strategy.Concrete;

public interface IPaymentStrategy
{
    void Pay(decimal amount);
}