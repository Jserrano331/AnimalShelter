using System;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
    public partial class Application
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int AnimalId { get; set; }
        public DateTime DateApplied { get; set; }
        public short Adopted { get; set; }
        public int EmployeeId { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual Applicant Applicant { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
