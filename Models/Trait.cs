using System;

namespace heal_fit.Models
{
    public class Trait
    {
        public int ID { get; set; }

        public string Value { get; set; }

        public TraitType Type { get; set; }

        public enum TraitType
        {
            POIDS, 
            TAILLE
        }

        public DateTime Date { get; set; }

        public int PlanID { get; set; }
    }
}