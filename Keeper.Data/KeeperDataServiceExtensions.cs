using Keeper.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Keeper.Data;

public static class KeeperataServiceExtensions
{
    public static IServiceCollection AddKeeperData(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        services.AddTransient<IFakeRepository, FakeRepository>();


        return services;
    }
}
