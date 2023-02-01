using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Dotnet
{
    //class is generic
    class AllGenericsEg<T> 
    {
        //generic member/field
        private T genericField;
        
        //generic property

        public T genericProperty { get; set; }
        //generic parameterized constructor
        public AllGenericsEg(T val)
        {
            genericField = val;
        }

        //generic Method of the class
        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type is: {0}, Parameter Values :{1}",typeof(T).ToString(),genericParameter);
            Console.WriteLine("Return Type is :{0}, Return Value is : {1}",typeof(T).ToString(),genericField);
            return genericField;
        }
    }

    class DriverClass
    {
        public void Display<T>(string msg, T val)
        {
            Console.WriteLine("{0} : {1}", msg,val);
        }
        static void Main()
        {
            //object initialized with int value type
            AllGenericsEg<int> allgenericsegint = new AllGenericsEg<int>(10);
            int outputval = allgenericsegint.genericMethod(200);

            //object initialized with string predefined reference type
            AllGenericsEg<string> allgenericsegstr = new AllGenericsEg<string>("Hi Generics");
            string outval = allgenericsegstr.genericMethod("Generics Method with string argument");
            
            //object initialized with user defined reference type
            AllGenericsEg<Employees> allgenericemp = new AllGenericsEg<Employees>(new Employees(1,"A",1000));
            Employees e = new Employees(5, "Banurekha", 10000);
            Console.WriteLine(allgenericemp.genericMethod(e));

            //hands on example
            DriverClass driverclass = new DriverClass();
            driverclass.Display<int>("Integer Data", 12);
            driverclass.Display<float>("Real number", 350.55f);
            driverclass.Display<char>("Character Data", 'b');
           
            Console.Read();
        }
    }
}
