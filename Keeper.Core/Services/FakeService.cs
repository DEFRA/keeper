using Keeper.Core.Models;
using Keeper.Data.Entities;
using Keeper.Data.Repositories;

namespace Keeper.Core.Services;

public interface IFakeService
{
    Task<FakeModel> GetAsync(string id);
}

public class FakeService(IFakeRepository repo) : IFakeService
{
    public async Task<FakeModel> GetAsync(string id)
    {
        return Map(await repo.GetAsync(id));
    }

    private static FakeModel Map(FakeEntity entity) => new()
    {
        Id = entity.Id,
    };
}
