using Command.Commands;
using Command.Invokers;
using Command.Receivers;

var cli = new CLI();
var fileSystemReceiver = new FileSystemReceiver();

cli.RegisterCommand("ls", new ListCommand(fileSystemReceiver));
cli.RegisterCommand("mkdir", new MakeDirectoryCommand(fileSystemReceiver));
cli.RegisterCommand("cd", new ChangeDirectory(fileSystemReceiver));


cli.ExecuteCommand(commandName: "ls");
cli.ExecuteCommand(commandName: "mkdir", ["foo"]);
cli.ExecuteCommand(commandName: "ls");

cli.ExecuteCommand(commandName: "cd", ["foo"]);
cli.ExecuteCommand(commandName: "mkdir", ["foo2"]);
cli.ExecuteCommand(commandName: "ls");

cli.ExecuteCommand(commandName: "cd", [".."]);
cli.ExecuteCommand(commandName: "ls", ["foo"]);
