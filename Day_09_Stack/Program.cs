using System.Collections;

class Program
{
	static void Main()
	{
		Stack<int> myStack = new();
		myStack.Push(3);
		myStack.Push(4);
		myStack.Push(5);
		int result = myStack.Pop();
		Console.WriteLine(result);
		Console.WriteLine(myStack.Pop());
	}
}