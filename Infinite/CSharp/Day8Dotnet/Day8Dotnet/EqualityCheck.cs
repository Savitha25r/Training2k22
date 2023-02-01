using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Dotnet
{
    class EqualityCheck
    {
        static void Main()
        {
            string s = "Niranjan";
            string s1 = s;
            Console.WriteLine("== Operator Results is {0}", s==s1);
            Console.WriteLine("Equals method Results is {0}",s.Equals(s1));
            Console.WriteLine("---------------");
            object obj = "Kavitha";
            char[] c = { 'K', 'a', 'v', 'i', 't', 'h', 'a' };
            object o = new string(c);
            Console.WriteLine("== Operator Results is {0}", obj == o);
            Console.WriteLine("Equals method Results is {0}", obj.Equals(o));
            Console.Read();
        }
    }
}
