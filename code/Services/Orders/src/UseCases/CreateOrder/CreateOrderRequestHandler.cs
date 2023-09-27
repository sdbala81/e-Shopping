using eShopping.Orders.Domain;

using Mapster;

using MediatR;

namespace eShopping.Orders.UseCases.CreateOrder;

public class CreateOrderRequestHandler : IRequestHandler<CreateOrderRequest, CreateOrderResponse>
{
    private readonly IAsyncRepository<Order> _orderAsyncRepository;

    public CreateOrderRequestHandler(IAsyncRepository<Order> orderAsyncRepository)
    {
        _orderAsyncRepository = orderAsyncRepository;
    }

    public async Task<CreateOrderResponse> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
    {
        var order = request.Adapt<Order>();

        var createdOrder = await _orderAsyncRepository.AddAsync(order, cancellationToken);

        var createdOrderResponse = createdOrder.Adapt<CreateOrderResponse>();

        return createdOrderResponse;
    }
}
