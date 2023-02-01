using System;
using System.Collections.Generic;

#nullable disable

namespace Core_EF_DBFirst.Models
{
    public partial class VwemployeeByDept
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public double? Salary { get; set; }
        public string Gender { get; set; }
        public string Deptname { get; set; }
    }
}
