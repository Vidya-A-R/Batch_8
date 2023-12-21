using CarComponent;

class Program 
{
	static void Main() 
	{
		Engine engine = new Engine();
		engine.valve = 4;
		Lamp lamp = new();
		Car car = new Car(engine,lamp);
		car.Start();
		
		Engine engine1 = new Engine();
		engine1.valve = 5;
		car.ChangeEngine(engine1);
		car.Start();

		Engine newEngine = new();
		ElectricEngine electricEngine = new();
		FogLamp fogLamp = new();
		Car newCar = new Car(electricEngine,fogLamp);

		//car.ChangeEngine(engine1);
		newCar.Start();
	}
}