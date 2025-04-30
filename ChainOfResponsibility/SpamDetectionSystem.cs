namespace ChainOfResponsibility;

public sealed class SpamDetectionSystem
{
    private readonly SpamHandler _chain;

    public SpamDetectionSystem()
    {
        _chain = new KeywordHandler();
        var blackListHandler = new BlackListHandler();
        var mlHandler = new MLHandler();

        _chain.SetSuccessor(blackListHandler);
        blackListHandler.SetSuccessor(mlHandler);
    }

    public bool CheckSpam(Email email)
    {
        return _chain.HandleSpamCHeck(email);
    }
}