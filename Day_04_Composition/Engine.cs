namespace CarComponent;

public class Engine
{
	public int valve;
	public virtual void EngineStart()
	{
		Console.WriteLine($"Engine run {valve}");
	}
	
}
