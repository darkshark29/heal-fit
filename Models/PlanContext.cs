using Microsoft.EntityFrameworkCore;

namespace heal_fit.Models
{
    public class PlanContext : DbContext
    {
        public PlanContext(DbContextOptions<PlanContext> options)
            : base(options)
        {
        }

        public DbSet<Plan> Plan { get; set; }
    }
}