using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day11Dotnet
{
    class ThreadLock
    {
        public static object tloc = new object();

        public static void Calculation()
        {
            lock (tloc)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " " + "Thread Started..");
                    Thread.Sleep(new Random().Next(5));
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }
        }

        public static void Main()
        {
            Thread thread1 = new Thread(new ThreadStart(Calculation));
            thread1.Name = "First Thread";
            thread1.Start();
            Thread thread2= new Thread(new ThreadStart(Calculation));
            thread2.Name = "Second Thread";
            thread2.Start();
            Console.Read();
        }
    }
}
