using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Enhancements_3
{
    class LambdaExpressions
    {
       static List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };
        static void Main()
        {
            //FindSquares();
            // Numbers_DivisibleBy3();
            //SortStudents();
            //ElementOperators();
            Aggregates();
            Console.Read();
        }

        public static void FindSquares()
        {         
            //display the elements in the list (numbers)
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //find the square of all the numbers in the numbers list
            var square = numbers.Select(x => x * x);

            //executing the query
            Console.WriteLine("Squares of Numbers ---");
            foreach (var n in square)
            {
                Console.Write("{0}\t", n);
            }
            Console.WriteLine();
        }

        //find all numbers divisible by 3
        public static void Numbers_DivisibleBy3()
        {
            List<int> div_by3 = numbers.FindAll(n => (n % 3) == 0);

            foreach(int a in div_by3)
            {
                Console.Write("{0}\t",a);
            }
            Console.WriteLine();
        }

        //sort all students based on their Names
        public static void SortStudents()
        {
            List<Student> studentlist = Student.GetStudents();

            var sortedstds = studentlist.OrderBy(b => b.Name);

            foreach(var item in sortedstds)
            {
                Console.WriteLine(item.ID + " "+item.Name + " " + item.Email);
            }

        }

        public static void ElementOperators()
        {
           // List<string> fruits = new List<string>() { "Banana", "Apple", "Oranges", "Mangoes", "Litchies", "Guava" };

            string[] fruits= { "Banana", "Apple", "Oranges", "Mangoes", "Litchies", "Guava" };
            var result = fruits.ElementAt(2);
            var result2 = fruits.ElementAtOrDefault(1); // does not throw exceptions if range is out of scope
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }

        public static void Aggregates()
        {
            var data = numbers.Average();
            Console.WriteLine(data);
            var data1 = numbers.Max();
            Console.WriteLine(data1);
        }       
    }
}
