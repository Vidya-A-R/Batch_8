public class Point
{
	public int X { get; set; }

	public Point(int x)
	{
		X = x;
	}

	// Overloading operator +
	public static Point operator +(Point left, Point right)
	{
		return new Point(left.X + right.X);
	}
	public static Point operator *(Point left, Point right)
    {
        return new Point(left.X * right.X);
    }

	public override string ToString()
	{
		return $"({X})";
	}
}

class Program
{
	static void Main()
	{
		Point p1 = new Point(5);
		Point p2 = new Point(6);

		Point p3 = p1 + p2; // Menggunakan operator + yang telah di-overload

		Console.WriteLine(p3); // Output akan menjadi (11)
	}
}
