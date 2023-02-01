using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Dotnet
{
    class Program
    {
        char data = 'A'; // non-static variable also called instance variable      
        static string CompanyAddress="Bangalore"; //static variable
        readonly string CompanyName = "Infinite"; //declaring and initializing
        readonly bool Limited; // initialized in the constructor
        const float PI=5.14f; // for const, need to assign values at the time of decl. itself
        
        //constructor
        public Program(char c, bool f)
        {
            data = c;
            Limited = f;
            // CompanyName = "ABC Corporation";
        }

        public Program(bool b, string compname)
        {
            Limited = b;
            CompanyName = compname;
        }
        static void Main(string[] args)
        {
            Program p = new Program('Z',true);
            Console.WriteLine("The Company is currently registered at " + " " +CompanyAddress);
            CompanyAddress = "Mumbai";
            Console.WriteLine("The Company is currently registered at " + " " + CompanyAddress);
            Console.WriteLine(p.data + " " +p.CompanyName+ " "+p.Limited);
            p.data = '1';
            // p.Limited = false; not possible to change
            // p.CompanyName = "MyCompany"; not possible to change
            Program p1 = new Program(false, "Abc Co.");
            p1.data = 'B';
            // p1.CompanyName = "New Co.";
            Console.WriteLine(Program.PI);
           // Program.PI = 3.14f; not possible to change
            Console.Read();
        }
    }
}
