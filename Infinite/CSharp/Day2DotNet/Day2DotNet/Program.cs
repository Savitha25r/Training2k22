using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.conversionfunc();
            //program.tryparsefunc();
            //program.Ternaryfunc();
            //NullableEg.nullableFunc();
            //NullableEg neg = new NullableEg();
            //neg.nullcoalescingFunc();
            ArraysEg arrayeg = new ArraysEg();
            //arrayeg.ArrayFunctions();
           // arrayeg.TwoDimensionalArray();
            arrayeg.JaggedArrayFunction();
            //DecisionMaking dm = new DecisionMaking();
            //dm.CheckGrade();
            //dm.CheckGradeWithSwitch();
            //Loops loops = new Loops();
            //Console.WriteLine("-------Do While-------");
            //loops.DoWhile();
            //Console.WriteLine("---------For Loop ----");
            //loops.ForLoop();
            //Console.WriteLine("--------While Loop----");
            //loops.WhileLoop();
            Console.Read();
        }
        #region
        public void conversionfunc()
        {
            int x = 10;
            // the below is to understand the primitive data type being represented as class type
            Console.WriteLine("Minimum Value of an Integer is {0}",int.MinValue);
             Console.WriteLine("Maximum Value :{0}",int.MaxValue);
              float f = x; //implicit conversion
              Console.WriteLine(f);
              Console.WriteLine("---------");
              f = 12345347556.45f;
            // x =(int) f;   //explicit conversion using typecast
              x = Convert.ToInt32(f); // explicit conversion using conversion functions

              Console.WriteLine(x);

        }
        #endregion

        #region
        public void Ternaryfunc()
        {
            //example for ternary operator
            int number = 15;
            bool b;
            if (number == 5)
            {
                b = true;
            }
            else
                b = false;
            Console.WriteLine("Number==5 is{0}", b);

            Console.WriteLine("------------");
            //the above code can be replaced with a ternary operator
            bool bl = number == 5 ? true : false;
            Console.WriteLine(bl);
        }
        #endregion
        #region
        public void tryparsefunc()
        {
            //example for tryparse
            Console.WriteLine("Enter a Number :");
            string str = Console.ReadLine();
            // x = Convert.ToInt32(str); throws exception
            // x = int.Parse(str); //throws exception
            int res;
            bool status = int.TryParse(str, out res);
            
            if (status == true)  //if success is true
            {
                Console.WriteLine("The parsed/converted data is {0}", res);
            }
            else
                Console.WriteLine("Invalid Data.. could not convert");
        }
        #endregion
    }
}
