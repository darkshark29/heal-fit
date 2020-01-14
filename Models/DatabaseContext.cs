using Microsoft.EntityFrameworkCore;

namespace heal_fit.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Acount { get; set; }
        public DbSet<Plan> Plan { get; set; }

    }
}