using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionEg
{
    public static class SecondClass
    {
        public static void Method3(this FirstClass fcobj)
        {
            Console.WriteLine("Method 3... as an extension");
        }

        public static void Method4(this FirstClass fobj,string s)
        {
            Console.WriteLine(s);
        }
    }
}
