using System.Collections;

class Program
{
	static void Main()
	{
		Queue<int> queue = new();
		queue.Enqueue(3);
		queue.Enqueue(4);
		queue.Enqueue(5);
		int result = queue.Dequeue();
		//queue.Peek();
		Console.WriteLine(result);
		Console.WriteLine(queue.Peek());
		//Console.WriteLine(result);
	}
}