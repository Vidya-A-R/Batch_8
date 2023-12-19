// See https://aka.ms/new-console-template for more information
using Day_02_Hewani;

class Program
{
	static void Main()
	{
		Bird bird = new Bird();
		bird.Chirp();
		
		Duck angsa = new Duck();
		angsa.Ngaos();
		
		Monkey monyet = new Monkey();
		monyet.Madang("Banana");
	}
	
}
