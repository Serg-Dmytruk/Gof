using Bridge.ClothingFormatters;

namespace Bridge.ClothingViews;

public sealed class CompactClothingView(IClothingFormatter clothingFormatter) : ClothingView(clothingFormatter)
{
    public override void Display()
    {
        Console.WriteLine("Compact clothing view");
        Console.WriteLine(ClothingFormatter.FormatTittle());
        Console.WriteLine(ClothingFormatter.FormatImageUrl());
        Console.WriteLine("");
    }
}