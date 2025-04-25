using Command.Receivers;

namespace Command.Commands;

public sealed class MakeDirectoryCommand(FileSystemReceiver fileSystemReceiver) : ICommand
{
    public void Execute(string[]? args)
    {
        if (args is null || args.Length < 1)
        {
            Console.Error.WriteLine("Invalid command arguments. Usage: mkdir <path>");
            return;
        }
        
        fileSystemReceiver.MakeDirectory(args[0]);
    }
}