namespace Day_02_Calculator;

public class Calculator
{
	//params keyword untuk menangkap semua data dengan syarat tipe datanya sama 
	//params harus diletakkan di akhir
	public int Add(params int[] numbers)
	{
		int result = 0;
		
		foreach(int number in numbers)
		{
			result = result + number;
		}
		return result;
	}
}
