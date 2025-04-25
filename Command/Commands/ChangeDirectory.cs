using Command.Receivers;

namespace Command.Commands;

public sealed class ChangeDirectory(FileSystemReceiver fileSystemReceiver) : ICommand
{
    public void Execute(string[]? args)
    {
        if (args is null || args.Length < 1)
        {
            Console.Error.WriteLine("Invalid command arguments. Usage: cd <path>");
            return;
        }
        
        fileSystemReceiver.ChangeDirectory(args[0]);
    }
}