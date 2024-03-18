using Domain.Entities;
using Infrastructures.Inrerfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Repositories;

public class JanrRepository(AppDbContext dbContext) : Repository<Janr>(dbContext), IJanrInterface
{
    public async Task<List<Janr>> GetAllWithReleationsAsync()
        =>  await _dbContext.Janrs
            .Include(j => j.Books)
            .ToListAsync();
}
