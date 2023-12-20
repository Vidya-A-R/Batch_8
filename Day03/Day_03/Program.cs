class Program
{
	static void Main()
	{
		Calcualtor calc = new Calcualtor();
		CalcChild calckid = new CalcChild();
		Console.WriteLine(calc.x);
		//Console.WriteLine(calc.y);
		calckid.Print();
	}
}
class Calcualtor
{
	internal int x = 3;
	protected int y = 5;
	protected string say = "hi, im the parent";
	
	private string _sayLess = "u ,can't access me";
}

class CalcChild : Calcualtor
{
		public void Print()
	{
		Console.WriteLine(y);
		Console.WriteLine(say);
	}
}
