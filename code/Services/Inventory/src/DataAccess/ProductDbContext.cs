using Ardalis.EFCore.Extensions;

using eShopping.Inventory.Domain;

using Microsoft.EntityFrameworkCore;

namespace eShopping.Inventory.DataAccess;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; } = null!;

    public DbSet<Product> ProductCategories { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();
    }
}
