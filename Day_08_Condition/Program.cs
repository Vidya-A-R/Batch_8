class Program
{
	static void Main(){
		Human human = new Human("a");
		human.NameCounter();
	}
}
class Human
{
	private string name;
	public Human(string name = "")
	{
		this.name = name;
	}
	public int NameCounter()
	{
		
		if(name is not null)
		{
			return name.Length;
		}
		return 0;
	}
}