using MediatR;

namespace eShopping.Orders.UseCases.CreateOrder;

public class CreateOrderRequest : IRequest<CreateOrderResponse>
{
    public string OrderDate { get; set; }

    public Guid CustomerId { get; set; }

    public List<OrderItemDto> OrderItems { get; set; } = new();

    // Todo - This should be an enum
    public string PaymentMethod { get; set; }
}


public class OrderItemDto
{
    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public bool IsIncreaseQuantity { get; set; }
}
