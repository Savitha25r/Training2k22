using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_EF_CodeFirst.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext db;

        public EmployeeRepository(EmployeeDbContext context)
        {
            db = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int eid)
        {
            Employee e = db.Employees.Find(eid);
            if(e!=null)
            {
                db.Employees.Remove(e);
                db.SaveChanges();
            }
            return e;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }

        public Employee GetEmployeeById(int eid)
        {
            return db.Employees.Find(eid);
        }

        public Employee UpdateEmployee(Employee empchanges)
        {
            var employee = db.Employees.Attach(empchanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return empchanges;

            //db.Employees.Attach(empchanges);
            //var entry = db.Entry(empchanges);
            //entry.Property(e => e.Name).IsModified = true;
            //entry.Property(e => e.Gender).IsModified = true;
            //entry.Property(e => e.Address).IsModified = true;
            //entry.Property(e => e.Salary).IsModified = true;
            //entry.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //db.SaveChanges();
            //return empchanges;
        }
    }
}
