using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Crud.Models
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int stdid);
        public List<Student> Create(Student s);
        public Student Update(int id, Student s);
    }
}
