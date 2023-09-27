using Ardalis.ApiEndpoints;

using eShopping.Inventory.UseCases.GetProduct;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace eShopping.Inventory.WebApi.Products;

[Route("/products")]
public class GetProductById : EndpointBaseAsync.WithRequest<GetProductByIdRequest>.WithActionResult<GetProductByIdResponse>
{
    private readonly ISender _sender;

    public GetProductById(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("/products/{productId}")]
    public override async Task<ActionResult<GetProductByIdResponse>> HandleAsync([FromRoute] GetProductByIdRequest request,
        CancellationToken cancellationToken = default)
    {
        var getProductByIdResponse = await _sender.Send(request, cancellationToken);

        return getProductByIdResponse;
    }
}
