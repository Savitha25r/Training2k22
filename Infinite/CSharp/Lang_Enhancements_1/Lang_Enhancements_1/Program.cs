using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Lang_Enhancements_1
{
    class Program
    {        
        static void Main(string[] args)
        {
            var MyType = new
            {
                data1 = "CSharp",
                data2 = 10,
                data3 = true,
                data4 = 35.55f,
            };
            WriteLine("Enter a number :");
            int number = ToInt32(ReadLine());
            WriteLine(MyType.ToString()); //invoking/making calls to a function
            Program p = new Program();
            p.LocalFunctions();
            secondclass.LiteralMovement();
            secondclass sc = new secondclass();
            sc.OptionalParameter("Seetha", 23456);
            sc.OptionalParameter("Geetha", 54468, "Mumbai");
            sc.NamedParameter("aa", "bb",15); //positional
            sc.NamedParameter(lname: "Sharma", age: 37, fname: "Rohit");
            sc.NamedParameter(age: 20, fname: "Niranjan", lname: "Krishnappa");
            Read();
        }

        public void LocalFunctions()
        {
            int a = 10, b = 5;
            int sum = Sum(a, b);
            int diff = Difference(a, b);
            WriteLine($"The Sum of a and b is {sum}");
            WriteLine($"The difference of a and b is {diff}");

            //inner or local functions
            int Sum(int x, int y)
            {
                int res = x + y;
                return res;
            }

            int Difference(int x, int y)
            {
                return x - y;
            }
            Console.WriteLine("Second Call to Local Function Sum :"+ Sum(10, 20));
        }        
    }

    partial class secondclass
    {
        public static void LiteralMovement()
        {
            var lit1 = 3457______6700_0089_0098_786; //digit seperator
            var lit2 = 0Xa3f_7ed; //hexadecimal
            var lit3 = 1100_1000_1000_0110_0011; //binary
            var lit4 = "This_is_to_understand_Literal_Movement";
            var lit5 = 1234_256.456_57;
            Console.WriteLine($"Data 1 : {lit1}, Data2 : {lit2}, Data3 :{lit3}, {lit5}");
        }

        public void NamedParameter(string fname, string lname, int age)
        {
            Console.WriteLine($"Fullname is :{fname}{lname}, Age :{age}");
        }
    }
}
