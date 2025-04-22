using Bridge.ClothingItems;

namespace Bridge.ClothingFormatters;

public class DressClothingFormatter(Dress dress) : IClothingFormatter
{
    public Uri FormatImageUrl()
    {
        return new Uri($"https://somedomain/images/shoe/{dress.Color}/{dress.Material}.jpg");
    }

    public string FormatTittle()
    {
        return $"{dress.Material} == {dress.Color}";
    }

    public string FormatDescription()
    {
        return "Dress description...";
    }
}