using System;
using System.Collections.Generic;

#nullable disable

namespace Core_EF_DBFirst.Models
{
    public partial class TblEmployee
    {
        public int EmpNo { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public int? ManagerId { get; set; }
        public DateTime? HireDate { get; set; }
        public decimal? Salary { get; set; }
        public decimal? Commision { get; set; }
        public int? DeptNo { get; set; }

        public virtual TblDepartment DeptNoNavigation { get; set; }
    }
}
