using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Dotnet
{
    class Flower
    {
        string name;
        string color;

        public Flower(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void Display()
        {
            Console.WriteLine(name + " " + "is in :" + color + " Color");
        }
    }
    class FlowerVase
    {
        Flower[] flowerobj = new Flower[5]; 

        public Flower this[float pos]
        {
            get { return flowerobj[(int)pos]; }
            set { flowerobj[(int)pos] = value; }
        }

        public Flower this[double s]
        {
            get { return flowerobj[(int)s]; }
            set { flowerobj[(int)s] = value; }
        }

        static void Main()
        {
            FlowerVase fv = new FlowerVase();
            fv[0.0f] = new Flower("Rose", "Red");
            fv[1.0f] = new Flower("Lillies", "White");
            fv[2.0f] = new Flower("December", "Purple");
            fv[3.0f] = new Flower("ShoeFlower", "Pink");
            fv[4.0f] = new Flower("Marigold", "Yellow");
            for (int i = 0; i < 5; i++)
            {
                fv[i].Display();
            }
            FlowerVase fv1 = new FlowerVase();
            fv1[0.0] = new Flower("Sample", "Grey");
            fv1[1.0] = new Flower("Example", "Black");

            fv1[0].Display();
            fv1[1].Display();
            Console.Read();
        }
    }
}
