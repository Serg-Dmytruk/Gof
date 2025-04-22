using Visitor.Visitors;

namespace Visitor.Elements;

public interface IDocumentElement
{
    void Accept(IDocumentVisitor visitor);
}