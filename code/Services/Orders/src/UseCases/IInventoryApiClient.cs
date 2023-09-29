using ElementLogic.eLogiq.GenericResponses;

using eShopping.Orders.UseCases.CreateOrder;

namespace eShopping.Orders.UseCases;

public interface IInventoryApiClient
{
    Task<Result<UpdateInventoryResponse>> UpdateInventory(UpdateInventoryRequest updateInventoryRequest,
        CancellationToken cancellationToken);
}
