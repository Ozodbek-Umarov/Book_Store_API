using Infrastructures.Inrerfaces;

namespace Infrastructures.Repositories;

public class UnitOfWork(AppDbContext dbContext)
    : IUnitOfWork
{
    private readonly AppDbContext dbContext = dbContext;

    public IAuthorInterface authorInterface => new AuthorRepository(dbContext);

    public IBookInterface bookInterface => new BookRepository(dbContext);

    public IJanrInterface janrInterface => new JanrRepository(dbContext);
}
