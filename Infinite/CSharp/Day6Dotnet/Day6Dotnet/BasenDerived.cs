using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Dotnet
{
    class Parent
    {
        int val1;
        public Parent(int v) 
        {
            val1 = v;
            Console.WriteLine("This is Parents value" + " "+val1);
        }
        //public Parent()
        //{
        //    Console.WriteLine("This is Parent");
        //}
        ~Parent()
        {
            Console.WriteLine("Bye from Parent ");
            Console.Read();
        }
        
    }

    class Child: Parent
    {
        int val2;
        public Child(int x) : base(x)
        {
            //val2 = x;
            Console.WriteLine("This is Childs Value" + " " + val2);
        }
        public Child(int x, int y) : base(y)
        {
            val2 = x;
            Console.WriteLine("This is Childs Value" + " " + val2);
        }
        ~Child()
        {
            Console.WriteLine("This is Bye from Child ..");
            Console.Read();
        }
    }
    class BasenDerived
    {
        static void Main()
        {
            Child child = new Child(5); //first constructor
            Child child2 = new Child(10, 15);
           
            Console.Read();
        }
    }
}
