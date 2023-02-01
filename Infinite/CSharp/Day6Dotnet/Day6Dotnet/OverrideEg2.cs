using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Dotnet
{
    class Shape
    {
        protected float R, L, B;

        public virtual float Area()
        {
            return 3.14f * R * R; //belongs to circle
        }

        public virtual float Circumference()
        {
            return 2 * 3.14f * R;
        }

        public void samplefunc()
        {
            Console.WriteLine("sample Function of Shape");
        }
    }
    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.WriteLine("Enter Length and Breadth :");
            L = float.Parse(Console.ReadLine());
            B = Convert.ToSingle(Console.ReadLine());
        }
        public override float Area()
        {
            return L * B;
        }

        public override float Circumference()
        {
            return 2 * (L + B);
        }
    }

    class Circle : Shape
    {
         new float R; //name hiding
        public void GetRadius()
        {
             Console.WriteLine("enter radius");
            R = Convert.ToSingle(Console.ReadLine());
        }
        public override float Area()
        {
            return 3.14f * R * R;
        }
        public new void samplefunc() //method hiding
        {
            Console.WriteLine("Sample Function of Circle");
        }
    }
    class OverrideEg2
    {
        static void Main()
        {
            Rectangle r = new Rectangle();
            r.GetLB(); //go to line no 31
            Console.WriteLine("Area of Rect :{0}",r.Area());
            Console.WriteLine("Perimeter of Rect :{0}",r.Circumference());
            Circle c = new Circle();
            c.GetRadius();
            Console.WriteLine("Area of Circle :{0}", c.Area());
            Console.WriteLine("Circumference of circle :{0}",c.Circumference());
            c.samplefunc();
            Console.Read();
        }
    }
}
