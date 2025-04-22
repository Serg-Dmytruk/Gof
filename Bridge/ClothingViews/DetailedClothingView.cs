using Bridge.ClothingFormatters;

namespace Bridge.ClothingViews;

public sealed class DetailedClothingView(IClothingFormatter clothingFormatter) : ClothingView(clothingFormatter)
{
    public override void Display()
    {
        Console.WriteLine("Detailed clothing view");
        Console.WriteLine(ClothingFormatter.FormatTittle());
        Console.WriteLine(ClothingFormatter.FormatDescription());
        Console.WriteLine(ClothingFormatter.FormatImageUrl());
        Console.WriteLine("");
    }
}