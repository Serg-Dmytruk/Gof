namespace Facade.Subsystem;

public sealed class Connection
{
    public async Task<YouTubeApp> LaunchAppAsync()
    {
        Console.WriteLine("Launching app...");
        await Task.Delay(1000);
        
        return new YouTubeApp();
    }
}