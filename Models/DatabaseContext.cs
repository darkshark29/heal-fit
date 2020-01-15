using Microsoft.EntityFrameworkCore;
using heal_fit.Models;

namespace heal_fit.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Account> Account { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<Profile> Profile { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Plan>().ToTable("Plan");
            modelBuilder.Entity<Profile>().ToTable("Profile");
            modelBuilder.Entity<Trait>().ToTable("Trait");
        }

        public DbSet<heal_fit.Models.Trait> Trait { get; set; }
    }
}