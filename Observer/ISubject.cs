namespace Observer;

public interface ISubject
{
    public void Subscribe(IObserver observer);
    public void UnSubscribe(IObserver observer);
    public void Notification();
}
