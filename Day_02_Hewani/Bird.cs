namespace Day_02_Hewani;

public class Bird : Animal
{
	public Bird(string name, int age) : base(name, age){

	}
	public void Chirp() 
	{
		Console.WriteLine("Kukuruyuk");
	}

}
