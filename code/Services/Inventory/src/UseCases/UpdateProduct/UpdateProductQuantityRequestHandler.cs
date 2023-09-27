using eShopping.Inventory.Domain;

using MediatR;

namespace eShopping.Inventory.UseCases.UpdateProduct;

public class UpdateProductQuantityRequestHandler : IRequestHandler<UpdateProductQuantityRequest, UpdateProductQuantityResponse>
{
    private readonly IAsyncRepository<Product> _productRepository;

    public UpdateProductQuantityRequestHandler(IAsyncRepository<Product> productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<UpdateProductQuantityResponse> Handle(UpdateProductQuantityRequest request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(request.ProductId, cancellationToken);

        if (request.IsIncreaseQuantity)
        {
            product.Quantity += request.Quantity;
        }
        else
        {
            product.Quantity -= request.Quantity;
        }

        await _productRepository.UpdateAsync(product, cancellationToken);

        return new UpdateProductQuantityResponse
        {
            ProductId = product.Id
        };
    }
}
