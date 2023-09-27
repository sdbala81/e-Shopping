using MediatR;

namespace eShopping.Inventory.UseCases.UpdateProduct;

public class UpdateProductQuantityRequest : IRequest<UpdateProductQuantityResponse>
{
    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public bool IsIncreaseQuantity { get; set; }
}
