using MediatR;

namespace eShopping.Inventory.UseCases.GetProduct;

public class GetProductByIdRequest : IRequest<GetProductByIdResponse>
{
    public Guid ProductId { get; set; }
}
