using Kairos.Desktop.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Kairos.Desktop;

/// <summary>
/// Composition root for Kairos. Registers application, infrastructure, and platform
/// services with the dependency injection container. Later tickets that introduce
/// real services should add their registrations here.
/// </summary>
internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddKairosServices(this IServiceCollection services, ILoggerFactory loggerFactory)
    {
        services.AddSingleton(loggerFactory);
        services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));

        services.AddTransient<MainViewModel>();

        return services;
    }
}