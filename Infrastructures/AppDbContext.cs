using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options)
{
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Janr> Janrs { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
}
