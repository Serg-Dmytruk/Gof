using Bridge.ClothingItems;

namespace Bridge.ClothingFormatters;

public sealed class ShoeClothingFormatter(Shoe shoe) : IClothingFormatter
{
    public Uri FormatImageUrl()
    {
        return new Uri($"https://somedomain/images/shoe/{shoe.Brand}/{shoe.Color}.jpg");
    }

    public string FormatTittle()
    {
       return $"{shoe.Brand} == {shoe.Color}";
    }

    public string FormatDescription()
    {
        return $"A {shoe.Brand} is a shoe of {shoe.Color} and is a {(shoe.IsAthletic ? "athletic" : "non-athletic")}.";
    }
}