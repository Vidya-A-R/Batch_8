class Calculator
{
	internal int x = 3;
	protected int y = 5;
	public void Count() 
	{
		Console.WriteLine("hi, the number is 5");
	}
}
class CalcChild : Calculator
{
	public new void Count()
	{
		Console.WriteLine("im the new word");
	}
}

class Program
{
	static void Main()
	{
		CalcChild calckid = new CalcChild();
		Calculator calc = calckid;
		Calculator calcTest = new CalcChild();
		calckid.Count();
		calcTest.Count();
		calc.Count();
	}
}

