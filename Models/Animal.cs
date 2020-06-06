using System;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
    public partial class Animal
    {
        public Animal()
        {
            Application = new HashSet<Application>();
        }

        public int Id { get; set; }
        public int SpeciesId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Breed { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public short? Neutered { get; set; }
        public DateTime IntakeDate { get; set; }

        public virtual Species Species { get; set; }
        public virtual ICollection<Application> Application { get; set; }
    }
}
