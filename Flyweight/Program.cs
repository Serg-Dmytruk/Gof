using Flyweight.Client;

var editor = new DocumentEditor();

var text = "Hello, Flyweight!";

var x = 10;
var y = 10;

foreach (var c in text)
{
    editor.InsertCharacter(c, "Ariel", x, y, 12, "black");
    x += 10;
}

var upperCaseText = text.ToUpper();


foreach (var c in upperCaseText)
{
    editor.InsertCharacter(c, "Times New Roman", x, y, 14, "blue");
    x += 12;
}

editor.Render();