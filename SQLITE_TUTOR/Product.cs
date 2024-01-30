using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SQLITE_TUTOR;

public class Product
{
	public int ProductId{get; set;}
	public string ProductName{get; set;} = null!;
	public int CategoryId{get; set;}
	public Category Category{get; set;} = null!;
	public double Cost{get; set;}
	public short Stock{get; set;}
}
