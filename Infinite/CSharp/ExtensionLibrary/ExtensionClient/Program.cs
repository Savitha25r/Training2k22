using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extension2;
using ExtensionLibrary;


namespace ExtensionClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //usual way of creating objects of the DLL class and calling its methods
            CalcClass cc = new CalcClass();
            int sum = cc.AddNum(15, 20);
            Console.WriteLine("The sum of 2 nos :{0}",sum);

             //with the concept of extension methods
            Console.WriteLine("The Difference of 2 nos : " + cc.SubtractNum(10, 5));
            Console.WriteLine("The Product of 2 nos :" + cc.MultiplyNum(5,6));
           
            Console.Read();
        }
    }
}
