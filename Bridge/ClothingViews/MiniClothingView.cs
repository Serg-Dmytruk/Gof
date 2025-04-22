using Bridge.ClothingFormatters;

namespace Bridge.ClothingViews;

public sealed class MiniClothingView(IClothingFormatter clothingFormatter) : ClothingView(clothingFormatter)
{
    public override void Display()
    {
        Console.WriteLine("Mini clothing view");
        Console.WriteLine(ClothingFormatter.FormatImageUrl());
        Console.WriteLine("");
    }
}