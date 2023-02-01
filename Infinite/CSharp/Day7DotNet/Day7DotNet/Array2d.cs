using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7DotNet
{
    class Array2d
    {
        static void Main()
        {
            int[,] arr2d = new int[3, 3]
            {
                {1,2,3},{4,5,6},{7,8,9}
            };
            string[,] str = new string[2, 2]
            {
                {"AA","BB" },
                {"CC","DD" }
            };
            // 1. read all elements thru loop
            for(int i=0;i<arr2d.GetLength(0);i++)
            {
                for(int j=0;j<arr2d.GetLength(1);j++)
                {
                   Console.Write(arr2d[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            // 2. read all elements thru foreach loop
            foreach(var v in arr2d)
            {
                Console.WriteLine(v);
            }

            foreach(var s in str)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}
