using Entities;
using Microsoft.EntityFrameworkCore;

namespace MyGraphQlNet.Persistence.Db;

public class ApplicationDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
}