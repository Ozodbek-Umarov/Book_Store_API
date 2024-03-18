using Domain.Entities;

namespace Infrastructures.Inrerfaces;

public interface IJanrInterface : IRepository<Janr>
{
    Task<List<Janr>> GetAllWithReleationsAsync();
}
