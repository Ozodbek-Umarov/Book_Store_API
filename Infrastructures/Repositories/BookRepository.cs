using Domain.Entities;
using Infrastructures.Inrerfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Repositories;

public class BookRepository(AppDbContext dbContext) 
    : Repository<Book>(dbContext), IBookInterface
{

    public async Task<List<Book>> GetAllWithAuthorAsync()
        => await _dbContext.Books
            .Include(b => b.Author)
            .ToListAsync();
}
