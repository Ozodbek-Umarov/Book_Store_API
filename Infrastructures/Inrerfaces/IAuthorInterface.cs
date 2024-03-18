using Domain.Entities;

namespace Infrastructures.Inrerfaces;

public interface IAuthorInterface : IRepository<Author>
{
    Task<List<Author>> GetAllWithReleationsAsync();
}
