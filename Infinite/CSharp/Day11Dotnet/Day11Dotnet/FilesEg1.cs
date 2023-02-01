using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day11Dotnet
{
    class FilesEg1
    {
        //reading and writing to files with stream reader/writer
        public void ReadData()
        {
             FileStream fs = new FileStream("MysampleFile.txt", FileMode.Open, FileAccess.Read);
            //FileStream fs = new FileStream(@"C:\Banu\Infinite\samplefile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            //position the file pointer at the beginning of the file
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            //reading till the end of file is encountered
            string str = sr.ReadLine();
            while(str!=null)
            {
                Console.WriteLine("{0}", str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        public void WriteData()
        {
            FileStream fs = new FileStream("MysampleFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            //prompt the user and get the string to write
            Console.WriteLine("Enter a String :");
            string str = Console.ReadLine();
            //write the eneterd string into MysampleFile.txt
            sw.Write(str);
            sw.Flush(); //clears the buffer
            sw.Close();
            fs.Close();
        }
        static void Main()
        {
            FilesEg1 fileseg1 = new FilesEg1();
            //fileseg1.WriteData();
            fileseg1.ReadData();
            Console.Read();
        }
    }
}
