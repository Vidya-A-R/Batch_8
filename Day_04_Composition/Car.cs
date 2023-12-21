using System.Text;
using CarComponent;

class Car
{
	public Engine engine;
	public Lamp lamp;
	
	public Car(Engine engine, Lamp lamp)
	{
		this.engine  = engine;
		this.lamp = lamp;
	}
	
	public void Start()
	{
		engine.EngineStart();
		lamp.TurnOn();
	}
	
	public void ChangeEngine(Engine replacement)
	{
		engine  = replacement;
		
	}
	
}