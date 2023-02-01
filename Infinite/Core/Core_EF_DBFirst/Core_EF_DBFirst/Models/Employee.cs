using System;
using System.Collections.Generic;

#nullable disable

namespace Core_EF_DBFirst.Models
{
    public partial class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public double? Salary { get; set; }
        public string Gender { get; set; }
        public int? DeptId { get; set; }
        public string Phone { get; set; }

        public virtual Department Dept { get; set; }
    }
}
