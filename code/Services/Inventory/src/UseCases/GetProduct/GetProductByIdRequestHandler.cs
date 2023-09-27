using eShopping.Inventory.Domain;

using MediatR;

namespace eShopping.Inventory.UseCases.GetProduct;

public class GetProductByIdRequestHandler : IRequestHandler<GetProductByIdRequest, GetProductByIdResponse>
{
    private readonly IAsyncRepository<Product> _productRepository;

    public GetProductByIdRequestHandler(IAsyncRepository<Product> productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<GetProductByIdResponse> Handle(GetProductByIdRequest request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(request.ProductId, cancellationToken);

        // Todo - How to properly handle null here.
        var getProductByIdResponse = new GetProductByIdResponse
        {
            Id = product.Id,
            Name = product.Name,
            Category = product?.Category?.Name,
            Price = product.Price,
            Quantity = product.Quantity
        };

        return getProductByIdResponse;
    }
}
