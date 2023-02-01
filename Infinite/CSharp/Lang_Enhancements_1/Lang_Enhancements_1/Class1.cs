using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Enhancements_1
{
    class Class1
    {

    }

    partial class secondclass
    {
        public void OptionalParameter(string name, float sal, string city = null, int ? age=null)
        {
            Console.WriteLine($"Name {name}, Salary : {sal}, City :{city}, Age :{age}");
        }
    }
}
