using System;
using System.Collections.Generic;


namespace Day10Dotnet
{
    class EnumerablevsEnumerator
    {
        public void ShowDifference()
        {
            List<string> Days = new List<string>();
            Days.Add("Sunday");
            Days.Add("Monday");
            Days.Add("Tuesday");
            Days.Add("Wednesday");
            Days.Add("Thursday");
            Days.Add("Friday");
            Days.Add("Saturday");

            //simple iteration with foreach
            foreach(string s in Days)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("============");
            //iteration with Ienumerable
            //IEnumerable<string> IEs = Days;
            //or the above assignment can also be type casted
            IEnumerable<string> IEs1 = (IEnumerable<string>)Days;
            foreach(string s in IEs1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("****************");
            //Iteration with IEnumerator

           // IEnumerator<string> Ien = (IEnumerator<string>)Days;
            //or
            IEnumerator<string> Ien1=Days.GetEnumerator();
            while(Ien1.MoveNext())
            {
                Console.WriteLine(Ien1.Current);
            }
        }

        static void Main()
        {
            EnumerablevsEnumerator ene = new EnumerablevsEnumerator();
            ene.ShowDifference();
            Console.Read();
            Console.WriteLine();
        }
    }
}
