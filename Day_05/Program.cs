abstract class Animal
{
	protected int age;
	protected string name;
	public Animal(int age, string name)
	{
		this.age = age;
		this.name = name;
	}
	//
	protected abstract void MakeSound();
	
	public virtual void Run()
	{
		Console.WriteLine("Animal running");
	}
}

class Dog : Animal

{
	public Dog(int age, string name) : base(age, name)
	{
		
	}
	protected override void MakseSound()
	{
		Console.WriteLine("Bark");
	}
	public overridevoid Run()
	{
		Console.WriteLine("Dog Run");
	}
}

class Program
{
	static void Main()
	{
		Animal animal = new Dog(3, "dog");
		animal.MakeSound();
		animal.Run();
		Console.WriteLine(animal.age);
		Console.WriteLine(animal.name);
		
	}
}

