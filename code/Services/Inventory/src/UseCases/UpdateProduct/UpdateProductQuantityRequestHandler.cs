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
        foreach (var orderItemDto in request.OrderItems)
        {
            var product = await _productRepository.GetByIdAsync(orderItemDto.ProductId, cancellationToken);

            Console.WriteLine($"Product: {product.Name} - Quantity: {product.Quantity}");

            if (orderItemDto.IsIncreaseQuantity)
            {
                product.Quantity += orderItemDto.Quantity;
            }
            else
            {
                product.Quantity -= orderItemDto.Quantity;
            }

            await _productRepository.UpdateAsync(product, cancellationToken);
        }

        return new UpdateProductQuantityResponse
        {
            OrderItemDtos = request.OrderItems
        };
    }
}
