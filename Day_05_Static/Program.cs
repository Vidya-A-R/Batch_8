class Program
{
	static void Main()
	{
		Car car = new Car(400);
		Console.WriteLine(car.GetCount());
		Car car2 = new Car(400);
		Console.WriteLine(car.GetCount());
		Car car3 = new Car(400);
		Console.WriteLine(car.GetCount());
		Car car4 = new Car(400);
		Console.WriteLine(car.GetCount());
		Car car5 = new Car(400);
		Console.WriteLine(car.GetCount());
		car5.GetPrice();
		car5.GetPrice2();
	}
}

class Car
{
	public static int count;
	public int price;
	
	public Car(int price)
	{
		count++;
		this.price = price;
	}
	
	public void GetPrice()
	{
		Console.WriteLine(price);
		
	}
	public static void GetPrice2()
	{
		//Pasti error
		Console.WriteLine(price);
	}
	
	public int GetCount()
	{
		//count++;
		return count;
	}
	
	public static int GetCount2()
	{
		//count++;
		return count;
	}
	
}
