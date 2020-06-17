using System;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
    public partial class Species
    {
        public Species()
        {
            Animal = new HashSet<Animal>();
        }

        public int Id { get; set; }
        public string Species_Type { get; set; }

        public virtual ICollection<Animal> Animal { get; set; }
    }
}
