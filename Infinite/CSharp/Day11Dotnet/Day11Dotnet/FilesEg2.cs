using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day11Dotnet
{
    //example for file operations using binary reader/writer
    class FilesEg2
    {
        public void BinaryRead()
        {
            BinaryReader bin_in= new BinaryReader(new FileStream("TestData.txt", FileMode.Open));
            int i = bin_in.ReadInt32();
            Console.WriteLine(i);
            double d = bin_in.ReadDouble();
            Console.WriteLine(d);
            bool b = bin_in.ReadBoolean();
            Console.WriteLine(b);
            double d1 = bin_in.ReadDouble();
            Console.WriteLine(d1);
            bin_in.Close();
        }
        public void BinaryWrite()
        {
            int i = 10;
            double d = 10234.55;
            bool b = true;
            BinaryWriter bin_out;
            bin_out = new BinaryWriter(new FileStream("TestData.txt", FileMode.Create));
            //Console.WriteLine("Writing " +i);
            bin_out.Write(i);
            bin_out.Write(d);
            bin_out.Write(b);
            bin_out.Write(12.2 * 7.4);
            bin_out.Close();
        }
        static void Main()
        {
            FilesEg2 file2 = new FilesEg2();
            file2.BinaryWrite();
            file2.BinaryRead();
            Console.Read();
        }

    }
}
