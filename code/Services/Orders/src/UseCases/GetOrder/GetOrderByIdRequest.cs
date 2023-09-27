using MediatR;

namespace eShopping.Orders.UseCases.GetOrder;

public class GetOrderByIdRequest : IRequest<GetOrderByIdResponse>
{
    public Guid OrderId { get; set; }
}
