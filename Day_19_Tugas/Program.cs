using System;
using System.Threading.Tasks;

class Program
{
	// Entry point of the program
	static async Task Main(string[] args)
	{
		// Await the MyMethod which is running asynchronously
		await MyMethod();
		Console.WriteLine("MyMethod has completed its task.");
	}

	// Asynchronous method that returns a Task
	public static async Task MyMethod1()
	{
		// Simulate asynchronous work (delay for 1 second)
		await Task.Delay(1000);
		Console.WriteLine("MyMethod is working...");
	}
	
	public static async Task MyMethod2()
	{
		
	}
}
