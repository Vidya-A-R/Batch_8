class Gaplekan
{
	public CardValue cardValue {get;}

}

public enum CardValue
{
	Two = 2,
	Three,
	Four,
	Five,
	Six,
	Seven,
	Eight,
	Nine,
	Ten,
	Jack,
	Queen,
	King,
	Ace
}

class Program
{
	static void Main()
	{
		int value = (int)CardValue.Two;
	}
}