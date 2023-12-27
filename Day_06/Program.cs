class Program
{
	static void Main()
	{
		int result = (int)ToyPrice.airSoftGun;
		Console.WriteLine(result);
		
		var discount = DiscountOrNo.airSoftGun;
		DiscountChecker(discount);
		
	}
	static void DiscountChecker(DiscountOrNo discount)
	{
		if(discount == DiscountOrNo.airSoftGun)
		{
			Console.WriteLine("dapet diskon");
		}
	}
	
	public enum ToyPrice
	{
		airSoftGun = 4000,
		aeroModelling = 3500,
		remoteControl = 5000,
		catapult = 300
	}
	
	public enum DiscountOrNo
	{
		airSoftGun,
		aeroModelling,
		remoteControl,
		catapult
		
		
	}
	
	
}