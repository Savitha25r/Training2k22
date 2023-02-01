using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day11Dotnet
{
    class FilesnDirectoriesEg
    {
        static void Main()
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Banu\Infinite\FSharp");
            if (dirinfo.Exists)
            {
                Console.WriteLine("Directory Fsharp already exists..");
                // return; if you want to check and come out
            }
            else
            {
                dirinfo.Create();
                Console.WriteLine("Directory Created ..");
            }
            //Example for Reading all subdirectories under a given directory
            DirectoryInfo mydir = new DirectoryInfo("c:\\Banu\\Infinite\\CSharp");
            if(mydir.Exists)
            {
                DirectoryInfo[] dirs = mydir.GetDirectories();
                foreach(object o in dirs)
                {
                    Console.WriteLine(o.ToString());
                }
            }
            else
            { 
                Console.WriteLine("Given directory does not exists");
            }
            // Example for Reading all files inside a directory
            FileInfo[] files = mydir.GetFiles();
            foreach(FileInfo f in files)
            {
                Console.WriteLine("FileName : {0}, Size :{1}",f.FullName,f.Length);
            }

            Console.Read();
        }
    }
}
