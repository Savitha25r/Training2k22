using System;
using System.Collections.Generic;

#nullable disable

namespace Core_EF_DBFirst.Models
{
    public partial class VwDoctorsInfo
    {
        public int? Did { get; set; }
        public string Doctorname { get; set; }
        public string Gender { get; set; }
        public string Splname { get; set; }
    }
}
