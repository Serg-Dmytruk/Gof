using Adapter.Adaptee;

namespace Adapter.Adapter;

public class RectangleAdapter(LegacyRectangle legacyRectangle) : IRectangle
{
    public long GetArea()
    {
        return legacyRectangle.CalculateArea();
    }

    public long GetPerimeter()
    {
        return legacyRectangle.CalculatePerimeter();
    }
}