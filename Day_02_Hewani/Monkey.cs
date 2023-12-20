namespace Day_02_Hewani;

public class Monkey : Animal
{
	public Monkey(string name, int age) : base(name, age){

	}
	public void Madang(string food)
	{
		Console.WriteLine($"The Monkey is eating {food}");
	}
}
