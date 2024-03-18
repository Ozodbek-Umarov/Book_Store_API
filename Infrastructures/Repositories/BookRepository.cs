using Domain.Entities;
using Infrastructures.Inrerfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Repositories;

public class BookRepository(AppDbContext dbContext) 
    : Repository<Book>(dbContext), IBookInterface
{
}
