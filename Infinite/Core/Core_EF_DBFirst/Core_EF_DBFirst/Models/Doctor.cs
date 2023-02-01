using System;
using System.Collections.Generic;

#nullable disable

namespace Core_EF_DBFirst.Models
{
    public partial class Doctor
    {
        public int? Did { get; set; }
        public string DoctorName { get; set; }
        public string Gender { get; set; }
        public int? SpId { get; set; }

        public virtual Specialization Sp { get; set; }
    }
}
