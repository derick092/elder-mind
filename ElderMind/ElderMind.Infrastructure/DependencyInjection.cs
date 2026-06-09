using ElderMind.Domain.Abstractions.Providers;
using ElderMind.Infrastructure.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace ElderMind.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IFileProvider, FileProvider>();
        
        return  services;
    }
}