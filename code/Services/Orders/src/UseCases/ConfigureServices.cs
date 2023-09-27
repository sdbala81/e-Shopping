using System.Reflection;

using ElementLogic.eLogiq.CleanArchitecture.Common.Behaviours;

using FluentValidation;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace eShopping.Orders.UseCases;

public static class ConfigureServices
{
    public static IServiceCollection AddUseCaseServices(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());

        // services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));

        return services;
    }
}
