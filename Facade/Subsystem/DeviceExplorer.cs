namespace Facade.Subsystem;

public sealed class DeviceExplorer
{
    public async Task<IDevice> GetAsync(Guid deviceId)
    {
        Console.WriteLine($"GetDeviceAsync: {deviceId}");
        await Task.Delay(1000);
        return new SmartTVDevice();
    }
}