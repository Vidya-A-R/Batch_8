using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class program 
{
	static void Main()
	{
		Bioskop bioskop = new(4);
		
		
	}
	
	
}

class Bioskop
{
	private int _studio;
	private int _x;
	
	public Bioskop(int x)
	{
		this._x = x;
	}
	public int Studio {
		get
		{
			return _studio;
		}
		set{
			_studio = _x;
		}
	}
	public void StudioBerapa()
	{
		Console.WriteLine(_studio);
	}
}

//Copy mas Kinara ga tahu kenapa punya ku error

/*class Program
{
	static void Main()
	{

	}
}
class Human
{
	private string _name;
	public int Brand { get; private set; } //common practice 
	public int Piece { get;  } //readonly
	public string Name //custom properties
	{
		get
		{
			return _name;
		}
		set
		{
			_name = _name + value;
		}
	}
	public string GetName()
	{
		return _name;
	}
	public void ChangeNameToDefault()
	{
		Name = String.Empty;
	}
	// public void SetName(string name)
	// {
	// 	_name = name;
	// }
}

*/
