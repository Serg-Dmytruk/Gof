using Visitor.Elements;

namespace Visitor.Visitors;

public class TextDocumentVisitor : IDocumentVisitor
{
    public void VisitTitle(Title title)
    { 
        Console.WriteLine(title.Text.ToUpper());
        Console.WriteLine(new string('=', title.Text.Length));
        Console.WriteLine();
    }

    public void VisitSubTitle(SubTitle subTitle)
    {
        Console.WriteLine(subTitle.Text);
        Console.WriteLine(new string('-', subTitle.Text.Length));
        Console.WriteLine();
    }

    public void VisitContent(Content content)
    {
        Console.WriteLine(content.Text);
        Console.WriteLine();
    }
}