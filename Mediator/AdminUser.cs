namespace Mediator;

public sealed class AdminUser(string name) : User(name)
{
    public override void Send(string message)
    {
        Console.WriteLine($"Admin {Name} announces: {message}");
        ChatMediator.Notify(this,$"ADMIN MESSAGE: {message}");
    }

    public override void Receive(string message, string senderName)
    {
        Console.WriteLine($"Admin {Name} receives from {senderName}: {message}");
    }

    public void BroadcastAlert(string message)
    {
        Console.WriteLine($"Admin {Name} broadcast alert: {message}");
        ChatMediator.Notify(this,$"ALERT: {message}");
    }
}