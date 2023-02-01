using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Dotnet
{
    class OurProgram
    {
        static void Main(string[] args)
        {
            List<Employees> emplist = new List<Employees>();
            emplist.Add(new Employees(101, "Harshini", 30000));
            emplist.Add(new Employees(102, "Harish", 31000));
            emplist.Add(new Employees(103, "Haritha", 32000));

            foreach(Employees e in emplist)
            {
                Console.WriteLine(e.ToString());
            }
            Console.Read();
        }
    }
    
    
}
