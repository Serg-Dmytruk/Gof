using Visitor.Elements;
using Visitor.Visitors;

List<IDocumentElement> elements =
[
    new Title("Visror design pattern"),
    new SubTitle("Intent"),
    new Content("Represent bla bla bla")
];

Console.WriteLine("TextDocumentVisitor");
var documentVisitor = new TextDocumentVisitor();

foreach (var element in elements)
{
    element.Accept(documentVisitor);
}

Console.WriteLine("MarkdownDocumentVisitor");
var markdownVisitor = new MarkdownDocumentVisitor();

foreach (var element in elements)
{
    element.Accept(markdownVisitor);
}