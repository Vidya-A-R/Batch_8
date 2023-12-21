using Microsoft.Win32.SafeHandles;

abstract class Helm()
{
	public abstract void Brand();
	
}
class HelmVidya : Helm
{
	public override void Brand()
	{
		Console.WriteLine("KYT");
	}

}

class Program
{
	static void
	HelmVidya Helem = new HelmVidya();
	Helem.Brand();
	
	
}