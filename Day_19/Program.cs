using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task task1 = Task.Run(() => Console.WriteLine("Task 1!"));
        Task task2 = Task.Run(() => Console.WriteLine("Task 2!"));

        await Task.WhenAny(task1, task2);
        int result = await MyMethodAsync();
        Console.WriteLine(result);
    }

    static async Task<int> MyMethodAsync()
    {
        await Task.Delay(2000);
        return 3; 
    }
}

