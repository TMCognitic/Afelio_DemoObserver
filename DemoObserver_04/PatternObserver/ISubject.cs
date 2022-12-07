namespace DemoObserver.PatternObserver
{
    public interface ISubject
    {
        event Action<ISubject>? NotifyHandler;
    }
}