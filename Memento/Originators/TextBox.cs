namespace Memento.Originators;

public sealed class TextBox
{
    private string _text = string.Empty;

    public void SetText(string text)
    {
        _text = text;
    }
    
    public string GetText() => _text;

    public class TextState
    {
        private readonly string _text;

        internal TextState(string text)
        {
            _text = text;
        }
        
        internal string GetText() => _text;
    }

    public TextState Save() => new(_text);

    public void Restore(TextState textState)
    {
        _text = textState.GetText();
    }
}