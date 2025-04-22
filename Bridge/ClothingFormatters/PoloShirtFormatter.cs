using Bridge.ClothingItems;

namespace Bridge.ClothingFormatters;

public sealed class PoloShirtFormatter(PoloShirt poloShirt) : IClothingFormatter
{
    public Uri FormatImageUrl()
    {
        return new Uri($"https://somedomain/images/shoe/{poloShirt.Brand}/{poloShirt.Color}.jpg");
    }

    public string FormatTittle()
    {
      return $"PoloShirt {poloShirt.Brand}";
    }

    public string FormatDescription()
    {
        return "PoloShirt description...";
    }
}