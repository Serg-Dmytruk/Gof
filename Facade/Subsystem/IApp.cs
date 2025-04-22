namespace Facade.Subsystem;

public interface IApp
{
    Task PlayAsync(Guid videoId);
}