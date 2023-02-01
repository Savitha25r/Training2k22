using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7DotNet
{
    class Shape
    {
        public virtual void DrawShape()
        {
            Console.WriteLine("Drawing Shape....");
        }
    }

    class Triangle : Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine("Drawing Triangle ....");
        }
        public void TFunc()
        {
            Console.WriteLine("Hi");
        }
    }
    class Square : Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine("Drawing Square ...");
        }
    }
    class Dynamic_Polymorphism
    { 
        static void Main()
        {
            /*Shape s = new Shape();
            s.DrawShape(); //line 12
            Triangle t = new Triangle();
            t.DrawShape(); //line 20*/
            //achieving dynamic polymorphism
            Shape s = new Shape();
            s.DrawShape(); //1st Output
            s = new Triangle(); //covariance
            s.DrawShape(); //2nd Output
            s = new Square();
            s.DrawShape(); //3rd Output
            Console.Read();
        }
    }
}
