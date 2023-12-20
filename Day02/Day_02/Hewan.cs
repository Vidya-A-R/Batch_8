namespace Furry;

public class Hewan
{
	public string gender;
	public string race;
	public int age;
	
	//Constructor
	public Hewan(string gender, string race, int age)
	{
		this.gender = gender;
		this.race = race;
		this.age = age;
	}
	
	//overloading constructor agar didapatkan parameter yang penting doang atau jika ada tambahan parameter(?)
	//ya kira - kira gitulah.
	
	//contoh pertama ini kalau yang penting itu cuman age doang maka untuk "gender" sama "race" nya bisa di 
	//tulis "unkown" keywordnya ini 
	public Hewan(int age, string gender = "unknown", string race = "unknown")
	{
		this.gender = gender;
		this.race = race;
		this.age = age;
	}
	
	//pada kasus ini mungkin overloadingnya age nya malah diilangin jadi nanti age nya malah di deklarasiin di 
	//bawah langsung maybe gitu penjelesan "dumb" nya ben aku cpet dong
	public Hewan(string gender, string race)
	{
		this.gender = gender;
		this.race = race;
		age = 1;
	}
	
	
	
	public void Meow()
	{
		Console.WriteLine("Im hungry gimme food");
	}
	public void Eat(string food)
	{
		Console.WriteLine($"miaaw ini enak " + food);
	}
	
	//reference for sinau
	//$ untuk string format
	//@ and \\ supress escape function for string

}
