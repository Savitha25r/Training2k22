using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionLibrary;

namespace Extension2
{
    public static class SubtractClass
    {
        public static int SubtractNum(this CalcClass cobj, int a, int b)
        {
            return a - b;
        }

        public static int MultiplyNum(this CalcClass cobj, int p, int q)
        {
            return p * q;
        }

        public static int DivideNum(int a, int b)
        {
            return a / b;
        }
        
    }
}
