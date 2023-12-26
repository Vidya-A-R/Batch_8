class MiconChecker
{
	public void CheckMicon(Micon micon)
	{
		Console.WriteLine(micon.Name());
	}	
	
}

abstract class Micon
{
	public abstract string Micon();
}

class Arduino : Micon
{
	public override string Micon()
	{
		return "Arduino Mega";
	}	
}

class ESP32 : Micon
{
	public override string Micon
	{
		return "ESP32 Nano";
	}
}

class Program
{
	static void Main()
	{
		MiconChecker micon = new();
		micon.Miconchecker(new Arduino());
	}
	
}

