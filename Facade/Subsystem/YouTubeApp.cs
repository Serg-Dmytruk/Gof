namespace Facade.Subsystem;

public sealed class YouTubeApp : IApp
{
    public async Task PlayAsync(Guid videoId)
    {
       Console.WriteLine($"YouTubeApp playing vide {videoId}...");
       await Task.Delay(1500);
    }
}