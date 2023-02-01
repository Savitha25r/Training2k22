using System;
using ClassLibrary1;

namespace Day9Dotnet
{
    class TestingDll
    {
        public static void Main()
        {
            CalculatorClass cc = new CalculatorClass();
            Console.WriteLine(cc.Add(5, 5));
            Console.WriteLine(cc.Multiply(5,5));
            Console.WriteLine(cc.Greetings());           
            Console.Read();
        }
    }
}
