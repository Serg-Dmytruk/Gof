namespace ChainOfResponsibility;

public class BlackListHandler : SpamHandler
{
    public override bool HandleSpamCHeck(Email email)
    {
        Console.WriteLine("BlackListHandler");
        
        if (ContainsSpamKeyword(email.Sender))
        {
            Console.WriteLine("BlackListHandler: is in black list");
            return true;
        }

        Console.WriteLine("KeywordHandler: isn't in black list");
        
        if (_successor is null)
        {
            return false;
        }

        return _successor.HandleSpamCHeck(email);
    }

    private static bool ContainsSpamKeyword(string text)
    {
        return text.Contains("Spam");
    }
}