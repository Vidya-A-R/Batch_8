// See https://aka.ms/new-console-template for more information
using Day_02_Hewani;

class Program
{
	static void Main()
	{
		Bird bird = new Bird("jay",3);
		bird.Chirp();
		
		Duck angsa = new Duck("wew",6);
		angsa.Ngaos();
		
		Monkey monyet = new Monkey("naise",4);
		monyet.Madang("Banana");

		Console.WriteLine(bird.name);
		Console.WriteLine(bird.age);

		Console.WriteLine(angsa.name);
		Console.WriteLine(angsa.age);

		Console.WriteLine(monyet.name);
		Console.WriteLine(monyet.age);
	}
	
}
