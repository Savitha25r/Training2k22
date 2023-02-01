using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Basic_Authentication.Models
{
    public class EmployeeBL
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> emplist = new List<Employee>();
            for(int i=0; i<10;i++)
            {
                if(i>5)
                {
                    emplist.Add(new Employee()
                    {
                        ID = i,
                        Name = "Name" + i,
                        Dept = "IT",
                        Salary = 1000 + i,
                        Gender="Male"
                    });                    
                }
                else
                {
                    emplist.Add(new Employee()
                    {
                        ID = i,
                        Name = "Name" + i,
                        Dept = "HR",
                        Salary = 1000 + i,
                        Gender = "Female"
                    });
                }
            }
            return emplist;
        }
    }
}