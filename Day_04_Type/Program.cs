using System.Net.Sockets;

class Program
{
	static void Main (){
		Car car = new Car(4);
		//before
		Console.WriteLine(car.price);
		Adder(car);
		//after
		Console.WriteLine(car.price);
	}
	
	public static void Adder(Car car)
	{
		car.price += 4;
	}
}

class Car
{
	public int price;
	public Car(int price)
	{
		this.price = price;
	}
}

