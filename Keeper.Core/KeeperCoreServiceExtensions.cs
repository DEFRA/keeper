using Keeper.Core.Services;
using Keeper.Data;
using Keeper.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Keeper.Core;

public static class KeeperCoreServiceExtensions
{
    public static IServiceCollection AddKeeperCore(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        services.AddTransient<ICoreFacade, CoreFacade>();
        services.AddTransient<IFakeService, FakeService>();


        services.AddKeeperData();
        services.AddKeeperInfrastructure();

        return services;
    }
}
