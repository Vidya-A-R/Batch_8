class Program 

{
	static void Main()
	{
		int a = 4;
		Console.WriteLine("first number" + a);
		Multiplier(ref a);
		Console.WriteLine("after" + a);
		
		int b = 1;
		Console.WriteLine("first number" + b);
		Multiplier3(out b);
		Console.WriteLine("after" + b);
		
		int c = 6;
		Console.WriteLine("first number" + c);
		Multiplier2(in c);
		Console.WriteLine("after" + c);
		
		
	}
	static void Multiplier(ref int input)
	{
		input *= input;
	}
	
	static void Multiplier2(in int input)
	{
		int result = input + 3;
	}
	
	static void Multiplier3(out int input)
	{
		input = 1000;
	}
}