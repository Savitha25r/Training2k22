using System;
using System.Collections.Generic;

#nullable disable

namespace Core_EF_DBFirst.Models
{
    public partial class Project
    {
        public int Eid { get; set; }
        public int Pid { get; set; }
        public string Prjname { get; set; }
        public string Duration { get; set; }
    }
}
