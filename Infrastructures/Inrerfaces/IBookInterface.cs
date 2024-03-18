using Domain.Entities;

namespace Infrastructures.Inrerfaces;

public interface IBookInterface : IRepository<Book>
{
    Task<List<Book>> GetAllWithAuthorAsync();
}
