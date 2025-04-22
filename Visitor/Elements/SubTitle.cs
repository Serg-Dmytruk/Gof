using Visitor.Visitors;

namespace Visitor.Elements;

public sealed class SubTitle(string text) : IDocumentElement
{
    public string Text { get; } = text;
    public void Accept(IDocumentVisitor visitor)
    {
       visitor.VisitSubTitle(this);
    }
}