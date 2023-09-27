namespace eShopping.Orders.Domain;

public class OrderItem : BaseEntity
{
    public Guid ProductId { get; set; }

    public byte Quantity { get; set; }

    public Order Order { get; set; }

    public Guid OrderId { get; set; }
}
