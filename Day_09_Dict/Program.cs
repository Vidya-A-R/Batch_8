using System.Collections;

class Program
{
	static void Main()
	{
		//cara mendeclare sebuah dictionary
		Dictionary<int,string> dict = new();
		dict.Add(1,"satu");
		dict.Add(2,"dua");
		string result = dict[2];
		Console.WriteLine(result);
		
		//untuk mengiterasi setiap fungsi dict
		foreach (var kvp in dict)
		{
			Console.WriteLine(kvp.Key);
			Console.WriteLine(kvp.Value);
			
		}
		
		//untuk mengetahui apakah terdapat key atau value di dalamnya
		Console.WriteLine(dict.ContainsValue("dua"));
		Console.WriteLine(dict.ContainsKey(1));
		
		SortedDictionary<int,string> sortedDict = new();
		sortedDict.Add(14,"tiga");
		sortedDict.Add(2,"dua");
		sortedDict.Add(15,"satu");
		
		foreach (var kvp in sortedDict)
		{
			Console.WriteLine(kvp.Key);
			Console.WriteLine(kvp.Value);
			
		}
	
	}
}