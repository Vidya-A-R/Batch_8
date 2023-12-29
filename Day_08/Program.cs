class Program
{
	static void Main(){
		Human human = new Human();
		human.NameCounter();
	}
}

class Human
{
	private string name;
	public int NameCounter()
	{
		int count;
		try
		{
			count = name.Length;
		}
		catch (Exception e)
		{
			count = 0;
		}
		return count;
	}
}