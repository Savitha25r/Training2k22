using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    //client2
    class TestsingleTon
    {
        static void Main()
        {
            SingleTonObject s1 = SingleTonObject.GetSingleTonObject();
            s1.SetMessage("Hi");
            Console.Read();
        }
    }

}
