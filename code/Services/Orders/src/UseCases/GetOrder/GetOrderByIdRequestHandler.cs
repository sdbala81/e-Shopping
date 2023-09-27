using MediatR;

namespace eShopping.Orders.UseCases.GetOrder;

public class GetOrderByIdRequestHandler : IRequestHandler<GetOrderByIdRequest, GetOrderByIdResponse>
{
    public async Task<GetOrderByIdResponse> Handle(GetOrderByIdRequest request, CancellationToken cancellationToken)
    {
        await Task.Delay(1000, cancellationToken);

        var orderResponse = new GetOrderByIdResponse
        {
            OrderId = request.OrderId
        };

        return orderResponse;
    }
}
