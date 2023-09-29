using System.Text;
using System.Text.Json;

using ElementLogic.eLogiq.GenericResponses;
using ElementLogic.eLogiq.Http.Client.Extensions;
using ElementLogic.eLogiq.Serialization;

using eShopping.Orders.UseCases;
using eShopping.Orders.UseCases.CreateOrder;

namespace eShopping.Orders.ExternalApiHttpClients;

public class InventoryApiClient : IInventoryApiClient
{
    private readonly HttpClient _httpClient;
    private readonly IJsonDeserializer _jsonDeserializer;

    public InventoryApiClient(IJsonDeserializer jsonDeserializer, HttpClient httpClient)
    {
        _jsonDeserializer = jsonDeserializer;
        _httpClient = httpClient;

        var daprAppId = Environment.GetEnvironmentVariable("DAPR_APP_ID") ?? throw new InvalidOperationException("DAPR_APP_ID is not set");
        Console.WriteLine(daprAppId);

        var daprPort = Environment.GetEnvironmentVariable("DAPR_HTTP_PORT")
         ?? throw new InvalidOperationException("DAPR_HTTP_PORT is not set");

        Console.WriteLine(daprPort);

        //_httpClient.BaseAddress = new Uri($"http://localhost:{daprPort}/v1.0/invoke/inventory/method/");

        _httpClient.BaseAddress = new Uri($"http://localhost:{daprPort}/");
        _httpClient.DefaultRequestHeaders.Add("dapr-app-id", daprAppId);
    }

    public async Task<Result<UpdateInventoryResponse>> UpdateInventory(UpdateInventoryRequest updateInventoryRequest,
        CancellationToken cancellationToken)
    {
        var serializedOrder = JsonSerializer.Serialize(updateInventoryRequest, _jsonDeserializer.SerializerOptions);

        var request = new HttpRequestMessage(HttpMethod.Put, "products")
        {
            Content = new StringContent(serializedOrder, Encoding.UTF8, "application/json")
        };

        using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);

        return await response.HttpClientResult<UpdateInventoryResponse>(_jsonDeserializer, cancellationToken);
    }
}
