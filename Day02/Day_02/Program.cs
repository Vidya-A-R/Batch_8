// See https://aka.ms/new-console-template for more information
using Hooman;
using Furry;

class Program 
{
	static void Main()
	{
		Manusia yanto = new Manusia(12,"Software Engineer","male");
		Manusia yayan = new Manusia(24,"Dodol bakso","male");
		
		Hewan abduh = new Hewan("male","romusha",4);
		Hewan yeni = new Hewan(gender : "Female",race : "persian");
		
		//untuk penyusunan parameter pada constructor mungkin perlu ada urutannya pada parameternya nah biar ga 
		//perlu untuk urut - urut banget bisa pake gini contohnya dibawah "age : 12" jadi ga perlu ngurutin
		//lagi nomernya
		
		Hewan cimol = new Hewan(age : 12);
		
		Console.WriteLine(cimol.age);
		Console.WriteLine(cimol.gender);
		Console.WriteLine(cimol.race);
		
		Console.WriteLine(yanto.gender);
		Console.WriteLine(yanto.job);
		Console.WriteLine(yanto.gender);
		
		cimol.Meow();
		cimol.Eat("lele");
		
	}

}
