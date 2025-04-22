namespace Bridge.ClothingFormatters;

public interface IClothingFormatter
{
    Uri FormatImageUrl();
    string FormatTittle();
    string FormatDescription();
}