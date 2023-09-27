namespace eShopping.Orders.Domain;

public class Order : BaseEntity
{
    public DateOnly OrderedDate { get; set; }

    public Guid CustomerId { get; set; }

    public List<OrderItem> OrderItems { get; set; } = new();
}
