using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day11Dotnet
{
    class SingleThreadEg
    {
        static void Main()
        {
            Thread t = Thread.CurrentThread;
            //By default the thread does not have any name
            //if you want, then you can provide a name explicitly
            t.Name = "Main Thread";
            Console.WriteLine("Current Executing Thread is : " + t.Name);
            Console.WriteLine("Current Executing Thread is : " + Thread.CurrentThread.Name);
            Method1();
            Method2();
            Method3();
            Console.Read();
        }

        static void Method1()
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("Method 1:" + i); 
            }
        }
        static void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method 2:" + i);
                if(i==3)
                {
                    Console.WriteLine("Data Copying Operation Started...");
                    //put the thread to sleep for 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("Data Copying Operation Completed");
                }
            }
        }
        static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method 3:" + i);
            }
        }
    }
}
