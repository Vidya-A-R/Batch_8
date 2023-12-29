class Program
{
	static void Main()
	{
		var myFunc = (int a, int b) => {return a + b;};
		var myFunc2 = (int a) => { return a > 0;};
		Action<string> myAction = (string a) =>{Console.WriteLine(a);};
		Action action = () => Console.WriteLine("nothing");
		
		int result = myFunc(3,4);
		Console.WriteLine(result);
		bool result2 = myFunc2(3);
		Console.WriteLine(result2);
		action();
		myAction("Nah ini dia");
	}
}