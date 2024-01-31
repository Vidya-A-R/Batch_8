using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace SQLITE_CODEFIRST;

class AnginKidul : DbContext
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

	{
		optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MyDatabase;Username=postgres;Password=postgres");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<Category>(category =>
		{
			category.HasKey(c => c.CategoryId);
			category.Property(c => c.CategoryName).IsRequired(true).HasMaxLength(40);
			category.Property(c => c.Description).IsRequired(false).HasMaxLength(50);
			category.HasMany(p => p.Products).WithOne(c => c.Category);
			//product.HasOne(p => p.Supplier).WithMany(c => c.Products);
		});
		modelBuilder.Entity<Product>(product =>
		{
			product.HasKey(p => p.ProductId);
			product.Property(p => p.ProductName).IsRequired(true).HasMaxLength(40);
			product.Property(p => p.Cost).HasColumnType("money").HasColumnName("UnitPrice");
			product.Property(p => p.Stock).HasColumnType("smallint").HasColumnName("UnitsInStock");
			product.HasOne(p => p.Category).WithMany(c => c.Products);
			//product.HasOne(p => p.Supplier).WithMany(c => c.Products);
		});
		modelBuilder.Entity<Category>().HasData(
			new Category()
			{
				CategoryId = 1,
				CategoryName = "Riffle",
				Description = "god weapon"
			},
			new Category()
			{
				CategoryId = 2,
				CategoryName = "Shotgun",
				Description = "noob weapon"
			}
		);
		modelBuilder.Entity<Product>().HasData(
			new Product()
			{
				ProductId = 1,
				ProductName = "Vandal",
				CategoryId = 1
			},
			new Product()
			{
				ProductId = 2,
				ProductName = "Judge",
				CategoryId = 2
			}
		);
		
	
	}
}