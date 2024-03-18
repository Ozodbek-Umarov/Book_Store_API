using Domain.Entities;
using Infrastructures.Inrerfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Repositories;

public class AuthorRepository(AppDbContext dbContext) : Repository<Author>(dbContext), IAuthorInterface
{

    public async Task<List<Author>> GetAllWithReleationsAsync()
        => await _dbContext.Authors
            .Include(a => a.Books)
            .ToListAsync();
}

