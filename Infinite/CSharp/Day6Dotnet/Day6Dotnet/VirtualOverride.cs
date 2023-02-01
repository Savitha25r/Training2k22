using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Dotnet
{
    class Baseclass
    {
        public void Message()
        {
            Console.WriteLine("Hello");
        }

        public virtual string Wishes(string s)
        {
            return "Hi "+ " " +s;
        }
    }
    class DerivedClass : Baseclass
    {
        public override string Wishes(string username)
        {
            //return base.Wishes(s);
            return "Welcome User " + username + " To CSharp";
        }
        static void Main()
        {
            DerivedClass dc = new DerivedClass();
            dc.Message();
            Console.WriteLine(dc.Wishes("Infinite")); 
            Console.Read();
          
        }
    }
    class VirtualOverride
    {
    }
}
