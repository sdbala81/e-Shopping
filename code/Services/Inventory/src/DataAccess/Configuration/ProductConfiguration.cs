using eShopping.Inventory.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopping.Inventory.DataAccess.Configuration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(e => e.Name)
            .IsRequired();

        builder.Property(e => e.Quantity)
            .IsRequired();

        builder.HasData(SeedData.Products());
    }
}
