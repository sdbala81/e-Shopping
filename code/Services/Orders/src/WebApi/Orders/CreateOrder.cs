using Ardalis.ApiEndpoints;

using eShopping.Orders.UseCases.CreateOrder;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace eShopping.Orders.WebApi.Orders;

[Route("/orders")]
public class CreateOrder : EndpointBaseAsync.WithRequest<CreateOrderRequest>.WithActionResult<CreateOrderResponse>
{
    private readonly ISender _sender;

    public CreateOrder(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost]
    public override async Task<ActionResult<CreateOrderResponse>> HandleAsync([FromBody] CreateOrderRequest request,
        CancellationToken cancellationToken = default)
    {
        var createOrderResponse = await _sender.Send(request, cancellationToken);

        return Ok(createOrderResponse);
    }
}
