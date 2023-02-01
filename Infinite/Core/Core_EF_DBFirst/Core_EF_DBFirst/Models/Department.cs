using System;
using System.Collections.Generic;

#nullable disable

namespace Core_EF_DBFirst.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public double? Budget { get; set; }
        public string City { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
