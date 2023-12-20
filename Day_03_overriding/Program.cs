class Calculator
{
	internal int x = 3;
	protected int y = 5;
	public virtual void Count() 
	{
		Console.WriteLine("hi, the number is 5");
	}
}
class CalcChild : Calculator
{
	public override void Count()
	{
		Console.WriteLine("im the new word");
	}
}

class CalcChild2 : Calculator
{
	//ngambil dari bapake
}

class Program
{
	static void Main()
	{
		CalcChild calckid = new CalcChild();
		Calculator calc = calckid;
		Calculator calcTest = new CalcChild();
		CalcChild2 calckid2 = new CalcChild2();
		calckid.Count();
		calcTest.Count();
		calckid2.Count();
		
	}
}

