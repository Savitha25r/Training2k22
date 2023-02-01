using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Enhancements_3
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
    }
    class DeferredVsImmediate
    {
        static void Main()
        {
            var emplist = new List<Employee>
            {
                new Employee{ID=1,Name="Santosh",Salary=30000},
                new Employee{ID=2,Name="Sameer",Salary=32000},
                new Employee{ID=3,Name="Ajay",Salary=40000},
                new Employee{ID=4,Name="Vijay",Salary=45000},
            };
            //query is constructed but does not execute here
            //1.
            var empName = emplist.Where(x => x.Salary < 35000).Select(y => y.Name);

            //query is constructed and executed here itself
            
            var NameImmediate = emplist.Where(x => x.Salary < 35000).Select(y => y.Name).ToList();
            //2. now adding one more employee

            emplist.Add(new Employee { ID = 5, Name = "Mahesh", Salary = 20000 });
            
            Console.WriteLine("--------Using Deferred Query--------");
            foreach(var e in empName)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("-------Using Immediate Query------");
            foreach(var e in NameImmediate)
            {
                Console.WriteLine(e);
            }
            
            Console.Read();
        }
    }
}
