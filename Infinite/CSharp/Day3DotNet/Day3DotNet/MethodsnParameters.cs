using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3DotNet
{
    class MethodsnParameters
    {
        //value type 
        public void SimpleMethod(int x)
        {
            Console.WriteLine("the value of the variable passed ");
            Console.WriteLine(x);
            x = 500;
            Console.WriteLine(x);
        }

        //reference type
        public void ReferenceMethod(ref int j)
        {
            Console.WriteLine("the value of the variable passed ");
            Console.WriteLine(j);
            j = 500;
            Console.WriteLine(j);
        }

        //out parameters
        public int Calculator( out int sum, out int prod, out int sub, int num1, int num2)
        {
            prod = num1 * num2; // "    "
            sum = num1 + num2; //addition result is sent as an output value
            sub = num1 - num2; // "  "    " 
            return num1 / num2;  // division result is being returned
           // Console.WriteLine(sum+ " " +prod);
        }
             
       static void Main()
        {
            int a = 10;
            MethodsnParameters mp = new MethodsnParameters();
            //calling a function using value
            // mp.SimpleMethod(a); 
            //  Console.WriteLine("Value of original variable" + " "+ a);
            //call by reference
            // mp.ReferenceMethod(ref a); 
            // Console.WriteLine("Value of original variable" + " "+a);
            //out parameters
            //int division;
            //int total,product,difference;
            //division=mp.Calculator( out total, out product, out difference, 20, 10);
            //Console.WriteLine($"Sum is {total}, product is {product}, difference is {difference} and division is {division}");
            //Console.WriteLine(total +" "+ product +" " +difference );            
            ParamArray parray = new ParamArray();
            //int totvalue = parray.AddElements(512, 720, 250, 567, 889);
            //Console.WriteLine("The sum of all elements is {0}",totvalue);
            //totvalue = parray.AddElements();
            //Console.WriteLine("The sum of all elements is {0}", totvalue);
            int[] num=new int[3] {10,20,30};
            ParamArray.ParamsMethod("firsttime"); // with 0 argument for params
            ParamArray.ParamsMethod("secondtime", num); //with 3 arguments of num
            ParamArray.ParamsMethod("thirdtime", 1, 2, 3, 4, 5, 6, 7, 8, 9); // with comma seperated value
            Console.WriteLine(parray.SampleFunc("Infinite", "Ltd")); 
            Console.Read();

        }
    }

    class ParamArray
    {
        public int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        public static void ParamsMethod(string s, params int[] numbers)
        {
            Console.WriteLine("The string values is {0}", s);
            Console.WriteLine("There are {0} elements", numbers.Length);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        public string SampleFunc(string s1, string s2)
        {
            string res=String.Concat(s1, s2);
            return res;
        }
    }
}
