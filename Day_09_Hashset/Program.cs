using System.Collections;

class Program
{
	static void Main()
	{
		HashSet<int> hashOne = new HashSet<int>();
		hashOne.Add(1);
		hashOne.Add(2);
		hashOne.Add(3);
		
		HashSet<int> hashTwo = new HashSet<int>();
		hashTwo.Add(2);
		hashTwo.Add(3);
		hashTwo.Add(4);
		
		hashOne.UnionWith(hashTwo);
		//hashOne.IntersectWith(hashTwo);
		//hashOne.ExceptWith(hashTwo);
		
		List<int> listOne = hashOne.ToList();
		int resultOne = listOne[3];
		
		List<int> listTwo = hashTwo.ToList();
		int resultTwo = listTwo[0];
		
		Console.WriteLine(resultOne);
		Console.WriteLine(resultTwo);
	}
}