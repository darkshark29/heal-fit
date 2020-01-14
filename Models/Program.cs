using heal_fit.Models;

namespace heal_fit.Models
{
    public class Program
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public ProgramType type { get; set; }

        // public Profile profile { get; set; }

        public enum ProgramType
        {
            IMC
        }

    }
}