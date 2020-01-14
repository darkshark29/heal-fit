using Microsoft.EntityFrameworkCore;

namespace heal_fit.Models
{
    public class ProgramContext : DbContext
    {
        public ProgramContext(DbContextOptions<ProgramContext> options)
            : base(options)
        {
        }

        public DbSet<Program> ProgramPrograms { get; set; }
    }
}