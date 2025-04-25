using Command.Commands;

namespace Command.Invokers;

public sealed class CLI
{
    private readonly Dictionary<string, ICommand> _commands = [];

    public void RegisterCommand(string commandName, ICommand command)
    {
        _commands[commandName] = command;
    }

    public void ExecuteCommand(string commandName, string[]? args = null)
    {
        var logArgs = args is not null ? string.Join(' ', args) : string.Empty;
        Console.WriteLine($"> {commandName} {logArgs}");
        
        if (_commands.TryGetValue(commandName, out var command))
        {
            command.Execute(args);
            return;
        }
        
        Console.Error.WriteLine($"Unknown command \"{commandName}\"");
    }
}