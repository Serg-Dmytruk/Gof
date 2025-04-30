namespace ChainOfResponsibility;

public sealed class KeywordHandler : SpamHandler
{
    public override bool HandleSpamCHeck(Email email)
    {
        Console.WriteLine("KeywordHandler");
        
        if (ContainsSpamKeyword(email.Subject) || ContainsSpamKeyword(email.Body))
        {
            Console.WriteLine("KeywordHandler: contains spam keyword");
            return true;
        }

        Console.WriteLine("KeywordHandler: does not contain spam keyword");
        
        if (_successor is null)
        {
            return false;
        }

        return _successor.HandleSpamCHeck(email);
    }

    private static bool ContainsSpamKeyword(string text)
    {
        return text.Contains("Nigerian Prince") || text.Contains("Million Dollars");
    }
}