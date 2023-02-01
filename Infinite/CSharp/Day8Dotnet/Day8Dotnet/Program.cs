using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Enter 2 nos :");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                int[] arr1 = { 2, 4, 6, 8 };
                Console.WriteLine(arr1[4]);
                Console.WriteLine(c);
                Console.Read();
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message + " " + fe.Source + " " + fe.StackTrace);
                Console.WriteLine("Please enter only numbers");
                Console.ReadKey();
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
                Console.Read();
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine("Trying to read data beyond scope");
                //Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //  Console.WriteLine("Something went wrong.. try again after sometime");
                Console.Read();
            }
            finally
            {
                Console.WriteLine("Reached Finally Block");
                Console.Read();
            }
        }               
    }
}
