using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Dotnet
{
    class Program
    {
        enum Days { N, B, Mon,Thur, Fri, Sat, Sun};
        enum cities { Bangalore=2, Chennai=6, Delhi=1, Hyderabad=5,Kolkatta,Mumbai,chennai}
        static void Main(string[] args)
        {
            //implicit type -- var
            var myvar="Hello";
            Console.WriteLine(myvar);
            myvar = "3456";
            Console.WriteLine(myvar);
            
            //dynamic  -- a reference type
            dynamic d;
            d = 5;
            d = 'a';
            d = "AAAA";
            d = 57667.6778;
            Console.WriteLine(d);

            int weekstart = (int)Days.Mon;
            int weekend = (int)Days.Fri;
            Console.WriteLine("Monday : {0}", weekstart);
            Console.WriteLine("Friday :{0}", weekend);
            //Console.WriteLine(typeof(Program));
            //int city1 =(int) cities.Kolkatta;
            //int city2 = (int)cities.Chennai;
            //Console.WriteLine(city1 + " "+city2);
            foreach (int x in Enum.GetValues(typeof(cities)))
            {
                if (x == 6)

                Console.WriteLine(x + " Is the Temple City of India");
                Console.WriteLine(Enum.GetName(typeof(cities), 6));
            }
            Console.WriteLine("==================");
            foreach (string s in Enum.GetNames(typeof(cities)))
                Console.WriteLine(s);
            Console.Read();
        }
    }
}
