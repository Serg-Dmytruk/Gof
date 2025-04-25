using Command.Receivers;

namespace Command.Commands;

public sealed class ListCommand(FileSystemReceiver fileSystemReceiver) : ICommand
{
    //ls
    //ls <path>
    public void Execute(string[]? args)
    {
        var path = args is null || args.Length < 1 ? "." : args[0];
        fileSystemReceiver.ListDirectory(path);
    }
}