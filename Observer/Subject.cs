namespace Observer;

public class Subject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();

    public int Temp{get; set;} = 0;
    public void Subscribe(IObserver observer){
        this._observers.Add(observer);
    }

    public void UnSubscribe(IObserver observer){
        this._observers.Remove(observer);
    }

    public void Notification(){
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public void ChangeTemperature(int temp){
        this.Temp = temp;
        this.Notification();
    }
}
