namespace Mediator;

public abstract class User(string name)
{
    public string Name { get; private set; } = name;
    protected IChatMediator ChatMediator = null!;

    public void SetMediator(IChatMediator chatMediator)
    {
        ChatMediator = chatMediator;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message, string senderName);
}