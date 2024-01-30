using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SQLITE_TUTOR;

class Program
{
	static async Task Main()
	{
		using (NorthWind db = new())
		{
			Console.WriteLine(db.Database.CanConnect());
			List<Category> categories = db.Categories.Include(c => c.Products).ToList();

			foreach (var c in categories)
			{
				Console.WriteLine($"{c.CategoryId} : {c.CategoryName}");
				Console.WriteLine(c.Products.Count());
				foreach (var p in c.Products)
				{
					Console.WriteLine($"	{p.ProductId} : {p.ProductName}");
				}
			}

			//For view Product that price is more than 20
			var products = db.Products.Where(p => p.Cost > 20);
			foreach (var p in products)
			{
				Console.WriteLine($"\t{p.ProductId} : {p.ProductName} cost : {p.Cost} stock : {p.Stock}");
			}
			//create
			Category category = new Category()
			{
				CategoryName = "Riffle",
				Description = "Senjata pro"
			};
			await db.Categories.AddAsync(category);
			await db.SaveChangesAsync();
			
			//Delete
			/*IQueryable<Category> deletedCategory = db.Categories
			.Where(c => c.CategoryName == "Riffle");
			
			db.Categories.RemoveRange(deletedCategory);
			await db.SaveChangesAsync();*/

		}

	}
}



