using Visitor.Elements;

namespace Visitor.Visitors;

public interface IDocumentVisitor
{
    void VisitTitle(Title title);
    void VisitSubTitle(SubTitle subTitle);
    void VisitContent(Content content);
}