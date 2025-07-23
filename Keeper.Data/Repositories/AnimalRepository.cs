using Keeper.Data.Entities;

namespace Keeper.Data.Repositories;

public interface IFakeRepository
{
    Task<FakeEntity> GetAsync(string id);
}

public class FakeRepository : IFakeRepository
{
    public Task<FakeEntity> GetAsync(string id)
    {
        return Task.FromResult(new FakeEntity { Id = "123" });
    }
}
