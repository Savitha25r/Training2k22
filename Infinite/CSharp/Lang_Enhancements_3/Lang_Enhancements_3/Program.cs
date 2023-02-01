using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Enhancements_3
{
    delegate void Print(int val);
    class Shape
    {
        private string shapename;
        public string SName
        {
            get
            {
                return shapename; 
            }
            set {
                shapename = value;
            }
        }

        public string Shapenm
        {
            get => shapename;
            set => shapename = value;
        }
        public void DelFunc(int a)
        {
            Console.WriteLine("Inside DelFunc Method" + a);
        }
        //normal method with minimal implementation
       public int GetAreaofRectangle(int l, int b)
        {
            return l * b;
        }

        //the above method can be rewitten with expr. bodied member
        public int GetAreaofRect(int l, int b) => l * b;

        public void Getname(string name) => Console.WriteLine($"The Given name is :{name}");

        public string LeapYear(int year) => $"\n Is{year} a Leap Year -" + DateTime.IsLeapYear(year);

    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();            
            Console.WriteLine("Normal Method"+ shape.GetAreaofRectangle(5, 6)) ;
            Console.WriteLine("Expression Bodied Method" + shape.GetAreaofRect(5, 6));
            Console.WriteLine(shape.LeapYear(2016));
            shape.Getname("Infinite");
          //  int area = shape.GetAreaofRectangle(10, 2);
            Print p = new Print(shape.DelFunc);
            p(10);
            //inline functions / Anonymous Functions using delegate
            //Print p1 = delegate(int x) { Console.WriteLine("Inside The Anonymous Method. The Value passed :{0}", x); };
            //inline functions / Anonymous Functions using delegate with fat arrow operator
            Print p1 = ((int x) =>{ Console.WriteLine("Inside The Anonymous Method. The Value passed :{0}", x);
                Console.WriteLine("Trying to Understand Inline functions");
            });
            p1(100);
            Console.WriteLine("----------------");
            p1(200);
            Console.Read();
        }
               
    }
}
