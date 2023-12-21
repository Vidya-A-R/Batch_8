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
		//pada kasus ini calckid mengoverride method count
		CalcChild calckid = new CalcChild();
		//pada kasus ini instance calculator diambil dari child class nya hal
		//tersebut ternyata bisa dilakukan namun output untuk methodnya tetap
		//method dari parentnya
		Calculator calc = calckid;
		//sama seperti yang diatas hanya saja keyword (?) nya beda
		Calculator calcTest = new CalcChild();
		calckid.Count();
		calcTest.Count();
		calc.Count();
	}
}

