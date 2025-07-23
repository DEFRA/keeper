using Keeper.Core.Services;
using Keeper.Data.Repositories;

namespace Keeper.Core;

public interface ICoreFacade
{
    IFakeService FakeService { get; }
}

public class CoreFacade(IFakeService fake) : ICoreFacade
{
    public IFakeService FakeService { get; } = fake;
}
