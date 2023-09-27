using ElementLogic.eLogiq.WebApi.Common;

using eShopping.Inventory.DataAccess;

using FluentValidation.AspNetCore;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eShopping.Inventory.WebApi;

public static class ConfigureServices
{
    public static IServiceCollection AddWebApiServices(this IServiceCollection services)
    {
        var assemblyName = typeof(ProductDbContext).Namespace;
        Console.WriteLine(assemblyName);

        services.AddDbContext<ProductDbContext>(
            options => options.UseSqlite(
                "Data Source=inventory.sqlite",
                builder => builder.MigrationsAssembly(assemblyName))); // will be created in web project root

        services.Configure<ApiBehaviorOptions>(
            options =>
            {
                options.SuppressInferBindingSourcesForParameters = true;

                // Todo: Need to figure out why the model is being validated without being called explicitly
                //options.SuppressModelStateInvalidFilter = true;
            });

        services.AddHttpContextAccessor();

        services.AddTransient<GlobalExceptionHandlingMiddleware>();

        services.AddFluentValidationAutoValidation();
        services.AddFluentValidationClientsideAdapters();

        return services;
    }
}
