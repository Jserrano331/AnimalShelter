using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Models
{
    public class Animal
    {
        public int Id { get; set; }

        public int species_id { get; set; }

        public string name { get; set; }

        public string gender { get; set; }

        public DateTime birthdate { get; set; }

        public string breed { get; set; }

        public string size { get; set; }

        public string color { get; set; }

        public int neutered { get; set; }

        public DateTime intake_date { get; set; }
    }
}
