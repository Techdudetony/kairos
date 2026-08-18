using Kairos.Desktop.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Kairos.Desktop;

/// <summary>
/// Composition root for Kairos. Registers application, infrastructure, and platform
/// services with the dependency injection container. Later tickets that introduce
/// real services should add their registrations here.
/// </summary>
internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddKairosServices(this IServiceCollection services)
    {
        services.AddTransient<MainViewModel>();

        return services;
    }
}