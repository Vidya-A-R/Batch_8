using System.Collections;
class Program
{
	
	static void Main ()
	{
		ArrayList myArrayList = new();
		myArrayList.Add(3);
		myArrayList.Add(true);
		myArrayList.Remove(3);
		myArrayList.RemoveAt(1);
		var isi = myArrayList[1];
	}
	
}