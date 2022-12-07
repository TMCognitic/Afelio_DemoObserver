namespace DemoObserver.PatternObserver
{
    public interface ISubject
    {
        void Attach(Action<ISubject> action);
        void Detach(Action<ISubject> action);
    }
}