using eShopping.Orders.Domain;

using Mapster;

using MediatR;

namespace eShopping.Orders.UseCases.CreateOrder;

public class CreateOrderRequestHandler : IRequestHandler<CreateOrderRequest, CreateOrderResponse>
{
    private readonly IInventoryApiClient _inventoryApiClient;
    private readonly IAsyncRepository<Order> _orderAsyncRepository;

    public CreateOrderRequestHandler(IAsyncRepository<Order> orderAsyncRepository, IInventoryApiClient inventoryApiClient)
    {
        _orderAsyncRepository = orderAsyncRepository;
        _inventoryApiClient = inventoryApiClient;
    }

    public async Task<CreateOrderResponse> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
    {
        var order = request.Adapt<Order>();

        var createdOrder = await _orderAsyncRepository.AddAsync(order, cancellationToken);

        var updateInventoryRequest = request.Adapt<UpdateInventoryRequest>();

        foreach (var orderItemDto in updateInventoryRequest.OrderItems)
        {
            orderItemDto.IsIncreaseQuantity = false;
        }

        await _inventoryApiClient.UpdateInventory(updateInventoryRequest, cancellationToken);

        var createdOrderResponse = createdOrder.Adapt<CreateOrderResponse>();

        return createdOrderResponse;
    }
}
