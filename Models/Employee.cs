using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string employee_type { get; set; }

        public string address { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string zipcode { get; set; }

        public DateTime date_hired { get; set; }
    }
}
