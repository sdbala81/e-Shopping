using Ardalis.ApiEndpoints;

using eShopping.Inventory.UseCases.UpdateProduct;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace eShopping.Inventory.WebApi.Products;

[Route("/products")]
public class UpdateProductQuantity : EndpointBaseAsync.WithRequest<UpdateProductQuantityRequest>.WithActionResult
{
    private readonly ISender _sender;

    public UpdateProductQuantity(ISender sender)
    {
        _sender = sender;
    }

    [HttpPut("/products")]
    public override async Task<ActionResult> HandleAsync([FromBody] UpdateProductQuantityRequest request,
        CancellationToken cancellationToken = new())
    {
        var response = await _sender.Send(request, cancellationToken);

        return Ok(response);
    }
}
