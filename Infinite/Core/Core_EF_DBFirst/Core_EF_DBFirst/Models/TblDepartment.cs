using System;
using System.Collections.Generic;

#nullable disable

namespace Core_EF_DBFirst.Models
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblEmployees = new HashSet<TblEmployee>();
        }

        public int DeptNo { get; set; }
        public string Dname { get; set; }
        public string Loc { get; set; }

        public virtual ICollection<TblEmployee> TblEmployees { get; set; }
    }
}
