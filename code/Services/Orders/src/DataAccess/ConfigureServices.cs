using eShopping.Orders.Domain;

using Microsoft.Extensions.DependencyInjection;

namespace eShopping.Orders.DataAccess;

public static class ConfigureServices
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));

        return services;
    }
}
