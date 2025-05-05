namespace Mediator;

public sealed class ChatRoom : IChatMediator
{
    private readonly List<User> _users = [];
    public void AddUser(User user)
    {
        _users.Add(user);
        user.SetMediator(this);
    }
    
    public void Notify(User sender, string message)
    {
        var receivers = _users.Where(user => user != sender);
        
        foreach (var receiver in receivers)
        {
            receiver.Receive(message, sender.Name);
        }
    }
}