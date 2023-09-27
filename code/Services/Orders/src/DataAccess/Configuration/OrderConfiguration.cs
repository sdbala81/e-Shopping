using eShopping.Orders.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopping.Orders.DataAccess.Configuration;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.Property(e => e.CustomerId)
            .IsRequired();

        builder.Property(e => e.OrderedDate)
            .IsRequired();
    }
}
