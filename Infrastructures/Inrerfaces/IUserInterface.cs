using Domain.Entities;

namespace Infrastructures.Inrerfaces;

internal interface IUserInterface : IRepository<User>
{
    Task<List<User>> GetAllWithReleationsAsync();
}
