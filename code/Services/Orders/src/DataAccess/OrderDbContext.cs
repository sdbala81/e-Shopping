using Ardalis.EFCore.Extensions;

using eShopping.Orders.Domain;

using Microsoft.EntityFrameworkCore;

namespace eShopping.Orders.DataAccess;

public class OrderDbContext : DbContext
{
    public OrderDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<OrderItem>()
            .HasOne(i => i.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(i => i.OrderId);

        modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();
    }
}
