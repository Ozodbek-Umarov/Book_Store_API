using Domain.Entities;

namespace Infrastructures.Inrerfaces;

internal interface IJanrInterface : IRepository<Janr>
{
    Task<List<Janr>> GetAllWithReleationsAsync();
}
