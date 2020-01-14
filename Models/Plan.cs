using heal_fit.Models;

namespace heal_fit.Models
{
    public class Plan
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public PlanType type { get; set; }

        // public Profile profile { get; set; }

        public enum PlanType
        {
            IMC
        }

    }
}