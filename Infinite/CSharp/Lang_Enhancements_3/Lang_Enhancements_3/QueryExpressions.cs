using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Enhancements_3
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
     
        //function to create a list of student details
        public static List<Student> GetStudents()
        {
            List<Student> stdlist = new List<Student>
            {
                new Student{ID=100,Name="Anupa",Email="Anupa@gmail.com"},
                new Student{ID=101,Name="Roopa",Email="Sairoopa@gmail.com"},
                new Student{ID=102,Name="Ramya",Email="ramya@gmail.com"},
                new Student{ID=103,Name="Chaithra",Email="chaitra@gmail.com"},
                new Student{ID=104,Name="Ismail", Email="Ismail@gmail.com"}
            };
            return stdlist;
        }
    }
    class QueryExpressions
    {
        static void Main()
        {
            int[] intarr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //query expression or query syntax
            IEnumerable<int> Oddvalues = from n in intarr
                                         where (n % 2) != 0
                                         select n;

            //iterate the fetched query results
            foreach(int n in Oddvalues)
            {
                Console.Write(n);
            }
            Console.WriteLine();

            //Query Expressions with User defined data types

            IEnumerable<string> names = from std in Student.GetStudents()
                                        where std.Name.StartsWith("R")
                                        select std.Name;

            IEnumerable<Student> s= from std1 in Student.GetStudents()
                             where std1.Name.EndsWith("l")
                             select std1;

            var stdobj = from a in Student.GetStudents()
                         where a.ID == 102
                         select a.Name;

            Console.WriteLine("List of Names");

            foreach(string str in names)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("List of Students");
            foreach(Student st in s)
            {
                Console.WriteLine(st.ID + " "+ st.Name + " "+st.Email);
            }
            Console.WriteLine("-----------");
            foreach(var v in stdobj)
            {
                Console.WriteLine(v);
            }
            Console.Read();
        }
    }
}
