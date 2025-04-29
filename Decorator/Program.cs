using Decorator;

var car = new LongRangeVolvoDecorator(new RedPaintVolvoDecorator(new BaseVovloModel()));

Console.WriteLine($"Description: {car.GetDescription()}");
Console.WriteLine($"Range: {car.GetRange()}");
Console.WriteLine($"Price: {car.GetPrice()}");
