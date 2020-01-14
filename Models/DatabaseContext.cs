using Microsoft.EntityFrameworkCore;

namespace heal_fit.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Account> Account { get; set; }
        public DbSet<Plan> Plan { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Plan>().ToTable("Plan");
        }
    }
}