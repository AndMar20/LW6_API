using API1;
using Microsoft.EntityFrameworkCore;

public class ProductServiceDbContext : DbContext
{
    public ProductServiceDbContext(DbContextOptions<ProductServiceDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
}