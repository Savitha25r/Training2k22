using System;
using System.Collections.Generic;

#nullable disable

namespace Core_EF_DBFirst.Models
{
    public partial class StdMark
    {
        public string Stdname { get; set; }
        public string Subjects { get; set; }
        public int? Marks { get; set; }
    }
}
