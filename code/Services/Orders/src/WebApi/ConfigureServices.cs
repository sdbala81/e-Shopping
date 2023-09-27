using ElementLogic.eLogiq.WebApi.Common;

using eShopping.Orders.DataAccess;

using FluentValidation.AspNetCore;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eShopping.Orders.WebApi;

public static class ConfigureServices
{
    public static IServiceCollection AddWebApiServices(this IServiceCollection services)
    {
        var assemblyName = typeof(OrderDbContext).Namespace;
        Console.WriteLine(assemblyName);

        services.AddDbContext<OrderDbContext>(
            options => options.UseSqlite(
                "Data Source=orders.sqlite",
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
