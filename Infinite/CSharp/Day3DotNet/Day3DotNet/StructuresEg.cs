using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3DotNet
{
    struct student
    {
        public int marks1;
        public int marks2;
    }
    class StructuresEg
    {        
        public static void structasvaluetype()
        {
            //student s1; or
            student s1 = new student();
            s1.marks1 = 50;
            s1.marks2 = 70;
            Console.WriteLine(s1.marks1+s1.marks2);
            student s2 = new student();
            s2 = s1;  //s1's values are copied and maintained seperately by s2 
                       // in case of structures
                       // in case of a class, the reference of s1 is copied into s2
            Console.WriteLine(s2.marks1+s2.marks2);
            s1.marks1 = 80;
            s1.marks2 = 80;
            Console.WriteLine("---After Reassigning s1 values ----");
            Console.WriteLine(s1.marks1 + s1.marks2);
            Console.WriteLine(s2.marks1 + s2.marks2);
            s2.marks1 = 100;
            Console.WriteLine(s1.marks1 + s1.marks2);
            Console.WriteLine(s2.marks1 + s2.marks2);

        }
    }
}
