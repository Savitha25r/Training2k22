using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionEg
{
    class Client
    {
        static void Main(string[] args)
        {
            FirstClass fc = new FirstClass();
            fc.Method1();
            fc.Method2();
            fc.Method3();
            fc.Method4("Extension Methods..");
            Console.Read();
        }
    }
}
