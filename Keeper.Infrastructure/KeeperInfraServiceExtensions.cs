using Microsoft.Extensions.DependencyInjection;

namespace Keeper.Infrastructure;

public static class KeeperInfraServiceExtensions
{
    public static IServiceCollection AddKeeperInfrastructure(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        


        return services;
    }
}
