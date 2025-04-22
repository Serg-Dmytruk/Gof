using Flyweight.Flyweight;
using Flyweight.FlyweightFactory;

namespace Flyweight.Client;

public class DocumentEditor
{
    private readonly GlyphFactory _glyphFactory = new();
    private readonly List<(IGlyph glyph, int x, int y, int size, string color)> _characters = [];
    
    public void InsertCharacter(char character, string fontFamily, int x, int y, int size, string color)
    {
        Console.WriteLine($"Insert {character} at ({x}, {y})");
        
        var glyph = _glyphFactory.GetGlyph(character, fontFamily);
        _characters.Add((glyph, x, y, size, color));
    }

    public void Render()
    {
        Console.WriteLine("Rendering document:");

        foreach (var character in _characters)
        {
            character.glyph.Render(character.x, character.y, character.size, character.color);
        }
    }
}