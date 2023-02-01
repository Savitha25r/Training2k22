using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Crud.Models
{
    public class StudentRepository : IStudentRepository
    {
        List<Student> studentlist; 
        public List<Student>stdList()
        {
             studentlist = new List<Student>()
            {
                new Student{StdId=1, StdName="Rishab",Gender="Male",Branch="CSC"},
                new Student{StdId=2, StdName="Janani",Gender="Female",Branch="ECE"},
                new Student{StdId=3, StdName="Krithika",Gender="Female",Branch="CSC"},
                new Student{StdId=4, StdName="Rohit",Gender="Male",Branch="IT"},
            };
            return studentlist;
        }

        public List<Student>GetAllStudents()
        {
            return stdList();
        }

        public Student GetStudentById(int stdid)
        {
            return stdList().FirstOrDefault(s => s.StdId == stdid);
        }

        public List<Student> Create(Student std)
        {
            List<Student> newlist = stdList();
            newlist.Add(std);
            return newlist;
        }

        public Student Update(int id, Student s)
        {
            var studentdata = stdList().Find(s => s.StdId == id);
            studentdata.StdName = s.StdName;
            studentdata.Branch = s.Branch;
            return studentdata;
        }
    }
}
