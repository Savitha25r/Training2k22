using System;
using System.Collections.Generic;

#nullable disable

namespace Core_EF_DBFirst.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Sname { get; set; }
        public string Email { get; set; }
    }
}
