using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Models
{
    public class Application
    {
        public int Id { get; set; }

        public int applicant_id { get; set; }

        public int animal_id { get; set; }

        public DateTime date_applied { get; set; }

        public string adopted { get; set; }

        public int employee_id { get; set; }
    }
}
