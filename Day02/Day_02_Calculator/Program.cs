// See https://aka.ms/new-console-template for more information

using Day_02_Calculator;
class Program
{
	static void Main()
	{
		Calculator calc = new Calculator();
		int resultOfSum = calc.Add(3,5,6,7,7);
		Console.WriteLine(resultOfSum);
	}
}