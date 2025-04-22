using Visitor.Elements;

namespace Visitor.Visitors;

public sealed class MarkdownDocumentVisitor : IDocumentVisitor
{
    public void VisitTitle(Title title)
    { 
       Console.WriteLine($"# {title.Text}");
       Console.WriteLine();
    }

    public void VisitSubTitle(SubTitle subTitle)
    {
        Console.WriteLine($"## {subTitle.Text}");
        Console.WriteLine();
    }

    public void VisitContent(Content content)
    {
        Console.WriteLine($"{content.Text}");
        Console.WriteLine();
    }
}