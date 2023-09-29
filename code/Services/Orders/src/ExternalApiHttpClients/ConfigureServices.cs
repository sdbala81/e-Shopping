using ElementLogic.eLogiq.Http.DelegateHandlers;
using ElementLogic.eLogiq.Serialization;

using eShopping.Orders.UseCases;

using Microsoft.Extensions.DependencyInjection;

namespace eShopping.Orders.ExternalApiHttpClients;

public static class ConfigureServices
{
    public static IServiceCollection AddHttpClientServices(this IServiceCollection services)
    {
        services.AddTransient<HttpDelegatingHandler>();

        services.AddHttpClient<IInventoryApiClient, InventoryApiClient>()
            .AddHttpMessageHandler<HttpDelegatingHandler>();

        services.AddScoped<IJsonDeserializer, ElementJsonDeserializer>();

        return services;
    }
}
