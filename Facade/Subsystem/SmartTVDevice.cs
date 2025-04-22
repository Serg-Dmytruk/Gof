namespace Facade.Subsystem;

public sealed class SmartTVDevice : IDevice
{
    public async Task<Connection> ConnectAsync()
    {
        await Task.Delay(1000);

        if (new Random().Next(1, 10) % 2 == 0)
            throw new Exception("TV is off");

        return new Connection();
    }

    public async Task<Connection> TurnOnAsync()
    {
        await Task.Delay(1000);
        Console.WriteLine("TV is on");
        
        return new Connection();
    }
}