using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Dotnet
{
    class Employees
    {
        int Eid;
        string Empname;
        double EmpSalary;

        public Employees(int id, string name, double sal)
        {
            Eid = id;
            Empname = name;
            EmpSalary = sal;            
        }

        public override string ToString()
        {
            return String.Format($"Employee with {Eid} id having name :{Empname}, earns a salary of Rs.{EmpSalary}");
            //or
            //return "Empid: " + " " + Eid + "Name is:" + " " + Empname + "draws a salary of Rs :" + EmpSalary;

        }
    }
}
