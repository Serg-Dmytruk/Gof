namespace Adapter.Adaptee;

public class LegacyRectangle(int left, int top, int right, int bottom)
{
    public int CalculateArea()
    {
        return (bottom - top) * (right - left);
    }

    public int CalculatePerimeter()
    {
        var height = bottom - top;
        var width = right - left;
        return 2 * (height + width);
    }
}