using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    class Program
    {
        static InfiniteDataContext db = new InfiniteDataContext();
        static void Main(string[] args)
        {
            var emp = from e in db.Employees
                      orderby e.DeptId
                      select e;

            //or

            var emp1 = db.Employees.ToList();
            foreach(var v in emp)
            {
                Console.WriteLine($"{v.Empid} {v.Empname} {v.Salary} {v.DeptId}");
            }
            Console.WriteLine("---------------");
            foreach(var v1 in emp1)
            {
                Console.WriteLine($"{v1.Empid} {v1.Empname} {v1.Salary} {v1.DeptId}");
            }

            var dept = db.FewEmployee();
            foreach(var e in dept)
            {
                Console.WriteLine($"{e.Empid} {e.DeptId} {e.Empname} {e.Salary}");
            }

            Console.Read();
        }
    }
}
