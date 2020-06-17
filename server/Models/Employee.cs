using System;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Application = new HashSet<Application>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeType { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public DateTime DateHired { get; set; }

        public virtual ICollection<Application> Application { get; set; }
    }
}
