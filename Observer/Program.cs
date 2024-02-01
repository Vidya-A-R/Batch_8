using Observer;

class Program
{
    static void Main()
    {
        Subject publisher = new();
        Observer1 observer1 = new();
        Observer2 observer2 = new();

        publisher.Subscribe(observer1);
        publisher.Subscribe(observer2);

        Console.WriteLine("input the temperature u want");
        string tempInput = Console.ReadLine();
        int temp = Convert.ToInt32(tempInput);
        publisher.ChangeTemperature(temp);

    }
}
