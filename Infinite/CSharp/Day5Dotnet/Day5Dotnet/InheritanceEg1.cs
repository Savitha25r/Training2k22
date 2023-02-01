using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Dotnet
{
    class Parent
    {
        public int a;
        protected int b;
        private int c;

        public Parent()
        {
            Console.WriteLine("Hi from parent");
        }
    }

    class Child : Parent
    {
        int childdata;
        public Child()
        {
            Console.WriteLine("Hi from Child");
        }

        public void ChildFunc()
        {
            Child child1 = new Child();
            child1.a = 10;
            child1.b = 20;
        }
    }
    class InheritanceEg1
    {
        public static void Main()
        {
            Child child1 = new Child();
            Console.Read();
        }
    }
}
