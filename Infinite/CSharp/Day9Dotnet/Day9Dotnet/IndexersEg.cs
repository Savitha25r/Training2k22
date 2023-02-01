using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Dotnet
{
    class IndexersEg
    {
        string[] names = new string[3];
        string[] phones = new string[3];
        int[] Marks = new int[3];
        string company;

        public string _company
        {
            get { return company; }
            set { company = value; }
        }

        //declare indexers to handle the index of the names field
        public string this[int flag]
        {
            get { string temp = names[flag]; return temp; }
            set { names[flag] = value; }
        }
        //declare overloaded indexers to handle the index of the phones field
        public string this[float f]
        {
            get
            {
                string temp = phones[(int)f];
                return temp;
            }
            set { phones[(int)f] = value; }
        }
        public string this[string s]
        {
            get
            {
                string temp = phones[1];
                return temp;
            }
            set { phones[1] = value; }
        }
        public string this[char d]
        {
            get
            {
                return phones[2];
            }
            set { phones[2] = value; }
        }

        public int this[double i]
        {
            get { return Marks[(int)i]; }
            set { Marks[(int)i] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexersEg ieg = new IndexersEg();
            ieg[0] = "Ramya";
            ieg[1] = "Chaithra";
            ieg[2] = "Haritha";
            Console.WriteLine(ieg[0] + " " + ieg[1] + " " + ieg[2]);

            //calling overloaded indexers to assign values (set)
            ieg[1.0f] = "123456";
            ieg["2"] = "34567";
            ieg['a'] = "00007";
            //printing from overloaded indexers (get)
            Console.WriteLine(ieg[1.0f] + "  " + ieg["2"] + "  " + ieg['a']);

            ieg[0.0] = 56;
            ieg[1.0] = 70;
            ieg[2.0] = 76;
            Console.WriteLine(ieg[0.0] + " " + ieg[1.0] + " " + ieg[2.0]);

            // we can work as below, if the fields were public
            //IndexersEg ieg2 = new IndexersEg();
            //ieg2.names[0] = "Shreedhara";
            //ieg2.names[1] = "Varsha";
            //ieg2.names[2] = "Dakshayani";
            //Console.WriteLine(ieg2.names[0] + ieg2.names[1] + ieg2.names[2]);
            Console.WriteLine("*****************");
            //calling a single indexer
            IndexersEg ieg1 = new IndexersEg();
            ieg1[0.0f] = "123";
            ieg1[1.0f] = "456";
            ieg1[2.0f] = "789";

            Console.WriteLine(ieg1[0.0f] + "  " + ieg1[1.0f] + "  " + ieg1[2.0f]);
            
            //we can work with properties to access private fields, if the
            // fields were single data
            ieg._company = "Infinite";
            Console.WriteLine(ieg._company);
            Console.Read();
        }
    }
}

