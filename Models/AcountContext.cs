using Microsoft.EntityFrameworkCore;

namespace heal_fit.Models
{
    public class AcountContext : DbContext
    {
        public AcountContext(DbContextOptions<AcountContext> options)
            : base(options)
        {
        }

        public DbSet<Acount> Acount { get; set; }

    }
}