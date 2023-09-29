using MediatR;

namespace eShopping.Inventory.UseCases.UpdateProduct;

public class UpdateProductQuantityRequest : IRequest<UpdateProductQuantityResponse>
{
    public List<OrderItemDto> OrderItems { get; set; } = new();
}
