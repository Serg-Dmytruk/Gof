using Flyweight.Flyweight;

namespace Flyweight.ConcreteFlyweight;

public class Glyph : IGlyph
{
    private readonly char _character;
    private readonly string _fontFamily;
    
    public Glyph(char character, string fontFamily)
    {
        _character = character;
        _fontFamily = fontFamily;
        
        Console.WriteLine($"Creating new glyph {_character} : {_fontFamily}");
    }
    
    //uses both extrinsicState and the intrinsic state
    public void Render(int x, int y, int size, string color)
    {
      Console.WriteLine($"Rendering glyph '{_character}', at {x}, {y} with size {size} and color {color}, using font family {_fontFamily}");
      
      //in a real application, this is where we'd render
      //the glyph, using the extrinsic and intrinsic state
    }
}