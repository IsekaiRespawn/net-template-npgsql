using Microsoft.EntityFrameworkCore;

namespace Entity;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> option) : base(option)
    {
    }

    public DbSet<User> Users => Set<User>();
}
