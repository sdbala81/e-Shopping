using eShopping.Orders.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopping.Orders.DataAccess.Configuration;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.Property(e => e.ProductId)
            .IsRequired();

        builder.Property(e => e.Quantity)
            .IsRequired();
    }
}
