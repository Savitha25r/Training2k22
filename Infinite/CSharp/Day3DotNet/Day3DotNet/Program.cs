using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3DotNet
{
    class Program
    {
        public static void StringEg()
        {
            string s = "Hello";
            Console.WriteLine(s.GetHashCode());
            s = "HelloWorld";
            Console.WriteLine(s.GetHashCode());
            string s1 = "CSharp";
            Console.WriteLine(s1.GetHashCode());
            string s2 = s1;
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s + " " + s1 + " " + s2);
            string s3 = "Hello"; //both address and data are taken from pool and assigned to s3
                                 // string s3 = new string("H")
            string[] s4 = new string[3] { "Hello", "Hello2", "Hello3" };
            Console.WriteLine(s3.GetHashCode());
            Console.WriteLine(s4.GetHashCode());
            Console.WriteLine("================");
            //string builders - mutable strings
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine(sb + " " + sb.GetHashCode());
            sb.Append("World");
            Console.WriteLine(sb + " " + sb.GetHashCode());
        }
        static void Main(string[] args)
        {
            //StringEg();
            StructuresEg.structasvaluetype();
            Console.Read();
        }
    }
}
