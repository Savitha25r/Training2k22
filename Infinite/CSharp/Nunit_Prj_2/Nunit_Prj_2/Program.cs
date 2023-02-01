using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Prj_2
{
    public class EmployeeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
    }

    public class Program
    {
        public string Login(string userid, string password)
        {
            if (string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(password))
            {
                return "UserId or Password cannot be null or Empty";
            }
            else
            {
                if (userid == "Admin" && password == "12345")
                {
                    return "Welcome Admin";
                }
                else
                    return "Invalid User Id Or Password";
            }
        }
        public List<EmployeeData> AllEmployees()
        {
            List<EmployeeData> emplist = new List<EmployeeData>()
        {
            new EmployeeData{Id=100, Name="Ajith",Salary=35000,Gender="Male"},
            new EmployeeData{Id=101, Name="Sanjay",Salary=38000,Gender="Male"},
            new EmployeeData{Id=102, Name="Sukanya",Salary=39000,Gender="Female"},
            new EmployeeData{Id=103, Name="Aruna",Salary=40000,Gender="Female"},
        };
            return emplist;
        }
               
        static void Main(string[] args)
        {
        }
    }
}
