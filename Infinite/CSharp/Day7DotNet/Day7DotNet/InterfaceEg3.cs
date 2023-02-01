using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7DotNet
{
    interface ICommonName
    {
        //interface declaring one string property called Name
        string Name { get; set; }
    }
    class Employee :ICommonName
    {
        //class implementing the string property 
        public string Name { get; set; }
    }
    class Company : ICommonName
    {
       string compname;
       string compadd;
      public int Age { get; set; }

        public string Name
        {
            get { return compname; }
            set { compname = value; }
        }
        public string Cadd
        {
            get { return compadd; }
            set { compadd = value; }
        }
    }
    class InterfaceEg3
    {
        static void Main()
        {
            Employee e = new Employee();
            e.Name = "Ismail";
            Company c = new Company();
            c.Name = "Infinite";
            c.Age = 24;
            c.Cadd = "Bangalore";
            Console.WriteLine("{0} from {1} whose office Location is at {2}, is {3} years old",e.Name,c.Name,c.Cadd,c.Age);
            Console.Read();
        }
    }

    
}

