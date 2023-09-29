namespace eShopping.Orders.UseCases.CreateOrder;

public class UpdateInventoryRequest
{
    public List<OrderItemDto> OrderItems { get; set; } = new();
}
