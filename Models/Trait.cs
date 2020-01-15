using System;

namespace heal_fit.Models
{
    public class Trait
    {
        public long Id { get; set; }

        public string Value { get; set; }

        public TraitType Type { get; set; }

        public enum TraitType
        {
            POIDS, TAILLE
        }

        public DateTime Date { get; set; }

        public int PlanId { get; set; }

        public Plan Plan { get; set; }
    }
}