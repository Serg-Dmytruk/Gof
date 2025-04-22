using Adapter.Adaptee;
using Adapter.Adapter;

var legacyRectangle = new LegacyRectangle(10, 10, 50, 100);
IRectangle rectangle = new RectangleAdapter(legacyRectangle);
ClientExecution(rectangle);
return;

void ClientExecution(IRectangle rectangle)
{
    Console.WriteLine($"area:{rectangle.GetArea()}");
}


