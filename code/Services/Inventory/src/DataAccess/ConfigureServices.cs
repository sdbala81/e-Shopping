using eShopping.Inventory.Domain;

using Microsoft.Extensions.DependencyInjection;

namespace eShopping.Inventory.DataAccess;

public static class ConfigureServices
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));

        return services;
    }
}
