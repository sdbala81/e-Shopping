using Ardalis.ApiEndpoints;

using eShopping.Orders.UseCases.GetOrder;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace eShopping.Orders.WebApi.Orders;

public class GetOrderById : EndpointBaseAsync.WithRequest<GetOrderByIdRequest>.WithResult<GetOrderByIdResponse>
{
    private readonly ISender _sender;

    public GetOrderById(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("/orders/{orderId}")]
    public override async Task<GetOrderByIdResponse> HandleAsync([FromRoute] GetOrderByIdRequest request,
        CancellationToken cancellationToken = default)
    {
        var getOrderByIdResponse = await _sender.Send(request, cancellationToken);

        return getOrderByIdResponse;
    }
}
