using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_EF_CodeFirst.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int eid);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee empchanges);
        Employee DeleteEmployee(int eid);

    }
}
