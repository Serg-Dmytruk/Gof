namespace ChainOfResponsibility;

public class MLHandler : SpamHandler

{
    public override bool HandleSpamCHeck(Email email)
    {
        Console.WriteLine("MLHandler");
        
        if (email.Body.Length % 2 == 0)
        {
            Console.WriteLine("Model predicted email is spam");
            return true;
        }

        Console.WriteLine("email is not spam");
        
        if (_successor is null)
        {
            return false;
        }

        return _successor.HandleSpamCHeck(email);
    }

    
}