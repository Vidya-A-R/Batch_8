namespace Day_02_Hewani;

public class Monkey : Animal
{
	public Monkey()
	{
		Console.WriteLine("Child");
	}
	public void Madang(string food)
	{
		Console.WriteLine($"The Monkey is eating {food}");
	}
}
