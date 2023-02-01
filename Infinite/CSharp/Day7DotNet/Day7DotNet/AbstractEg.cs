using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7DotNet
{
   abstract class Shapeclass
    {
        //declaring abstract method with asbtract modifier, without definition
          abstract public int Area();
       // abstract public float CalculatePercentage(float val);

        //non abstract method with definition
        public void Display()
        {
            Console.WriteLine("Hi I am Abstract class");
        }
    }

    class SquareClass : Shapeclass
    {
        int side;
        public SquareClass(int n)
        {
            side = n;
        }
        public override int Area()
        {
            return side * side;
        }
    }

    sealed class finalclass
    {
        public void Message()
        {
            Console.WriteLine("This is Message");
        }
    }
    class AbstractEg  
    {
        static void Main()
        {
            Shapeclass sc = new SquareClass(4);
            Console.WriteLine(sc.Area());
            sc.Display();
            finalclass fc = new finalclass();
            fc.Message();
            Console.Read();
        }
    }
}
