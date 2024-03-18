using Domain.Entities;

namespace Infrastructures.Inrerfaces;

internal interface IBookInterface : IRepository<Book>
{
    Task<List<Book>> GetAllWithAuthorAsync();
}
