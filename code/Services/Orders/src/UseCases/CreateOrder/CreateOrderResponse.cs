namespace eShopping.Orders.UseCases.CreateOrder;

public class CreateOrderResponse : CreateOrderRequest
{
    public Guid Id { get; set; }
}
