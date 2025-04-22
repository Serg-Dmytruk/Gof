using Strategy.Concrete;
using Strategy.Context;

var shoppingCart = new ShoppingCart();

shoppingCart.SetStrategy(new CreditCartStrategy("John Doe", "1234"));
shoppingCart.Checkout(100);

shoppingCart.SetStrategy(new BankTransferStrategy());
shoppingCart.Checkout(110);

shoppingCart.SetStrategy(new PayPallStrategy());
shoppingCart.Checkout(120);
