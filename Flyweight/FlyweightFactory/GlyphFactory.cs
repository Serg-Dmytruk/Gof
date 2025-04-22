using Flyweight.ConcreteFlyweight;
using Flyweight.Flyweight;

namespace Flyweight.FlyweightFactory;


public class GlyphFactory
{
    private readonly Dictionary<(char character, string fontFamily), IGlyph> _glyphs = [];

    public IGlyph GetGlyph(char character, string fontFamily)
    {
        if (!_glyphs.ContainsKey((character, fontFamily)))
        {
            _glyphs.Add((character, fontFamily), new Glyph(character, fontFamily));
        }
        
        return _glyphs[(character, fontFamily)];
    }
}