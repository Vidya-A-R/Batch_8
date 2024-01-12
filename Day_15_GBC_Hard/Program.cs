using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int iteration = 1_000_000_000;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for(int i = 0; i < iteration; i++)
        {
            sb.Append("a");
            sb.Append("b");
            sb.Replace('a', 'c');
        }
        stopwatch.Stop();

        Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}
