using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Dotnet
{
    class A
    {
        public string name;
        private int number;
        internal float salary;
        protected DateTime DOJ;
        protected internal char x;

        public void Func1()
        {
            DOJ = Convert.ToDateTime("30/09/2022");
            number = 007;
            name = "Banurekha";
            salary = 45000;
            x = 'X';
            Console.WriteLine($"{DOJ},{number},{salary}, {name},{x}");
        }
    }

    class B : A
    {
        static void Main()
        {
            A a1 = new A();
            a1.name = "Banu"; // public,internal,internal protected
            a1.salary = 25000;
            a1.x = 'A';
             B b1 = new B();
            //b1.
            //with the child class object b1, public,internal,protected and internal protected are accessible
        }

    }
    class Sample 
    {
        public void test()
        {
            A a2 = new A();
            a2.x = '6'
;        }
    }
}
