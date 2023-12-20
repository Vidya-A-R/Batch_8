// See https://aka.ms/new-console-template for more information
class Bike
{
	public readonly string year;
	public const string pemilik = "Yeni";
	public Bike(string year)
	{
		this.year = year;
	}
	
	public void TellBike()
	{
		Console.WriteLine(pemilik);
	}
}

class Program
{
	static void Main ()
	{
		Bike bike = new Bike("2004");
		Console.WriteLine(bike.year);
		bike.TellBike();
	}
}