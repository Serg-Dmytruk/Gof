using Facade.Subsystem;

namespace Facade;

public sealed class CastingFacade(DeviceExplorer deviceExplorer)
{
    public async Task CastAsync(Guid deviceId, Guid videoId)
    {
        var device = await deviceExplorer.GetAsync(deviceId);

        if (device is not SmartTVDevice smartTVDevice)
        {
            throw new Exception("Device is not a SmartTV device");
        }

        Connection connection;
        try
        {
            connection =  await smartTVDevice.ConnectAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            connection = await smartTVDevice.TurnOnAsync();
            await Task.Delay(2000);
        }

        var app = await connection.LaunchAppAsync();

        if (app is not YouTubeApp youTubeApp)
        {
            throw new Exception("YouTubeApp is not a YouTubeApp");
        }

        await youTubeApp.PlayAsync(videoId);
    }
}