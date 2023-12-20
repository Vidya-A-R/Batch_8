class Calculator
{
	internal int x = 3;
	protected double y = 5.66;
	public int Change(double y) 
	{
		x =(int) y;
		return x;
	}
}
class CalcChild : Calculator
{
	public void Count()
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
		//calcTest.Change();
		Console.WriteLine(calc.x);
		//calc.Count();
	}
}

