using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7DotNet
{
    class MethodOverload
    {
        public void Swap(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;            
            Console.WriteLine("Swapping of integers num1= "+ num1+ "num2 ="+ num2);
        }
        public static void Swap(char c1, char c2)
        {
            char temp = ' ';
            temp = c1;
            c1 = c2;
            c2 = temp;
            Console.WriteLine("Swapping of characters c1 = " + c1 + "c2 = "+ c2);
        }
        static void Main(string[] args)
        {
            MethodOverload p = new MethodOverload();
            p.Swap(5, 4); // call is resolved by the compiler
            p.Swap('a', 'b');
            Swap('z', 'p');
            Console.Read();
        }
    }
}
