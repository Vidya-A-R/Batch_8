
class Program{
	static void Main()
	{
		String myString = "hey";
		myString.Dump();
		int result = 1.Tambah(2);
		result.Dump();
	}
}
	
	public static class Extention
	{
		public static void Dump(this object x)
		{
			Console.WriteLine(x);
		}
		public static int Tambah(this int x, int y)
		{
			return x+y;
		}
	}
