using System.Collections.Generic;
using heal_fit.Models;

namespace heal_fit.Models
{
    public class Plan
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Trait> Traits { get; set; }
        public int ProfileID { get; set; }

        public PlanType Type { get; set; }

        // public Profile profile { get; set; }

        public enum PlanType
        {
            IMC
        }

    }
}