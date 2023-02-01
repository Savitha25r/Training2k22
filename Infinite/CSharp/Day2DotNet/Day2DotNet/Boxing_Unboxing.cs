using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2DotNet
{
    class Boxing_Unboxing
    {
        static void Main()
        {
            int i = 10; // value type
            int z = i;
            object obj; //reference type
            obj = i; // value type to reference type -- boxing
            Console.WriteLine(obj);
            string str = "222";
            obj = str; // implicit typecasting
            Console.WriteLine(obj);

          //  i = (int)obj;   //unboxing 
            i = Convert.ToInt32(obj); //unboxing
            i = int.Parse(str); //unboxing
            float salary;  //value type
            Console.WriteLine("Enter Salary :");
            salary = Convert.ToSingle(Console.ReadLine());// or
            //salary = float.Parse(Console.ReadLine()); //reference type to value type -- unboxing
            Console.WriteLine($"salary entered is {salary}");
            Console.Read();
        }
        
    }
}
