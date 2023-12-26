/*public interface IHandPhone
{
	void Camera();
	void Wifi();
	void Telpon();
}*/

public interface ICamera
{
	void Camera();	
}
public interface IWifi
{
	void Wifi();	
}
public interface ITelpon
{
	void Telpon();	
}

public interface IHandPhoneMahal : ITelpon, ICamera, IWifi
{
	
}

public class HandphoneEsia : ITelpon
{
	public void Telpon()
	{
		Console.WriteLine("Calling");
		
	}
}

public class Iphone : IHandPhoneMahal
{
	public void Camera()
	{
		Console.WriteLine("Cekrik");
		
	}
	public void Telpon()
	{
		Console.WriteLine("Calling");
		
	}
	public void Wifi()
	{
		Console.WriteLine("Konek");
		
	}
}

class Program
{
	static void Main ()
	{
		CheapPhone(new HandphoneEsia());
		Phone(new Iphone());
	}
	
	static void Phone(IHandPhoneMahal handPhoneExpensive)
	{
		handPhoneExpensive.Camera();
	}
	static void CheapPhone(ITelpon handPhoneCheap)
	{
		handPhoneCheap.Telpon();
	}
}


