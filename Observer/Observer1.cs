namespace Observer;

public class Observer1 : IObserver
{
    public void Update(ISubject subject){
        if((subject as Subject).Temp > 100){
            Console.WriteLine("Fire!!!!!");
        }
    }
}