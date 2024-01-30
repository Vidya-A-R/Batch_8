using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace SQLITE_TUTOR;

class NorthWind : DbContext
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

	{
		optionsBuilder.UseSqlite("FileName=./Northwind.db");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<Product>(product =>
		{
			product.HasKey(p => p.ProductId);
			product.Property(p => p.ProductName).IsRequired(true).HasMaxLength(40);
			product.Property(p => p.Cost).HasColumnType("money").HasColumnName("UnitPrice");
			product.Property(p => p.Stock).HasColumnType("smallint").HasColumnName("UnitsInStock");
			product.HasOne(p => p.Category).WithMany(c => c.Products);
			//product.HasOne(p => p.Supplier).WithMany(c => c.Products);
		});
	
	}
}