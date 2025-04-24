using Memento.Caretakers;
using Memento.Originators;

var textBox = new TextBox();
var textHistory = new TextHistory();

textHistory.Backup(textBox.Save()); //Save empty string

textBox.SetText("Hello");
textHistory.Backup(textBox.Save());

textBox.SetText("Hello, Memento!");
textHistory.Backup(textBox.Save());

Console.WriteLine($"Current text: {textBox.GetText()}");

textHistory.Undo(textBox);
Console.WriteLine($"After undo: {textBox.GetText()}");

textHistory.Undo(textBox);
Console.WriteLine($"After second undo: {textBox.GetText()}");

textHistory.Redo(textBox);
Console.WriteLine($"After redo: {textBox.GetText()}");

textHistory.Redo(textBox);
Console.WriteLine($"After second redo: {textBox.GetText()}");