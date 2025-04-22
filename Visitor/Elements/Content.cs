using Visitor.Visitors;

namespace Visitor.Elements;

public sealed class Content(string text) : IDocumentElement
{
    public string Text { get; } = text;
    public void Accept(IDocumentVisitor visitor)
    {
       visitor.VisitContent(this);
    }
}