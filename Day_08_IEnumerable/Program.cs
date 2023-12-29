using System.Runtime.CompilerServices;
using System.Collections;

class Program
{
	static void Main()
	{
		String[] myString = {"yey","yuhu","hehe"};
		IEnumerator enumerator = myString.GetEnumerator();
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);
		enumerator.Reset();
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);
		
	}
}