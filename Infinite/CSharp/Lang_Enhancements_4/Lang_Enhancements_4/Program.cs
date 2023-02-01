using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Enhancements_4
{
    class Program
    {
        static int [] numbers = new int[] { 1, 2, 3, 4, 5 };
        static string[] city = { "Ambala", "Mumbai", "Nagpur", "abc", "Jaipur","Delhi", "Bangalore", "Hyderabad", "Chennai", "Ahmedabad" };
        public static void Simple_Aggregates()
        {
            var result = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine("Aggregated Product is :{0}", result);
            foreach(int n in numbers)
            {
                Console.WriteLine(n);
            }    
        }

       public static void  Aggregates_WithSeed()
        {
            var sum = numbers.Sum(); // 15
            Console.WriteLine(sum);
            var res = numbers.Aggregate(10.5, (a, b) => a + b);
            Console.WriteLine("Aggregated Sum with a seed value :{0}",res);
        }

        public static void FirstEg()
        {
            string[] colors = { "Red", "Blue", "Green","Yellow","Black","White" };
            Console.WriteLine(colors.First());
            Console.WriteLine(colors.Last());
            string[] c1 = { };
            Console.WriteLine(c1.FirstOrDefault()); //does not throw exception
            Console.WriteLine(c1.LastOrDefault()); //""
        }

        public static void SingleEg()
        {
            string[] names1 = { "Amitabh Batchan" };
            string[] names2 = { "JoeBiden", "Donald", "Trump", "Obama" };
            string[] empty = { };
            Console.WriteLine(names1.Single());
          //  Console.WriteLine(names2.SingleOrDefault()); //throws exception
            Console.WriteLine(empty.SingleOrDefault());
        }
        public static void ByEg()
        {
           
            var result = city.OrderBy(c => c.Length).ThenBy(c => c);
            
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("***************");
            var result1 = city.OrderByDescending(c => c.Length).ThenByDescending(c => c);
            foreach (string str in result1)
            {
                Console.WriteLine(str);
            }            
        }

        public static void TakenSkip()
        {
            //take and skip eg
            Console.WriteLine("------Take----------");
            var res = city.Take(4);
            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------Skip--------");
            var skip1 = city.Skip(3);
            foreach (string s in skip1)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------Take While-----");
            var r = city.TakeWhile(c => c.Length == 6);
            foreach (string s in r)
            {
                Console.WriteLine(s);
            }

            //skip
            Console.WriteLine("-------Skip While-------");
            string[] str1 = { "one", "two", "six", "three", "four", "five", "xyz" };
            var sortedstr = str1.OrderBy(s => s.Length);
            Console.WriteLine("---------Sorted Str--------");
            foreach(string str in sortedstr)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-------Skip While in a Sorted Collection------");
            var skip = sortedstr.SkipWhile(m => m.Length == 3);
            foreach(string st in skip)
            {
                Console.WriteLine(st);
            }
        }
        public static void Group_ByEg()
        {
            int[] numarray = { 10, 15, 20, 25, 30, 35, 42 };

            var numgroup = numarray.GroupBy(n => (n % 10 == 0));

            foreach(IGrouping<bool,int> igp in numgroup)
            {
                if(igp.Key==true)
                {
                    Console.WriteLine("Divisible Group ");
                }
                else
                {
                    Console.WriteLine("Non divisible group");
                }
                foreach(int n in igp)
                {
                    Console.WriteLine(n);
                }
            }        
        }
        static void Main(string[] args)
        {
            // Simple_Aggregates();
            //Aggregates_WithSeed();
            // FirstEg();
            //SingleEg();
            //ByEg();
            // TakenSkip();
            Group_ByEg();
            Console.Read();
        }  
    }
}
