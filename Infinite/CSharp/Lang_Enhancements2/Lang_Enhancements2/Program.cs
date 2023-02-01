using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Enhancements2
{
    class Employee
    {
        public int ID { get; } = 1010;
        public string Ename { get; set; } = "Janice";
        public float ESal { get; private set; } = 35000;
        public string City { get; protected set; } = "Delhi";

        //public Employee()
        //{
        //    Ename = "janice";
        //    ESal = 35000;
        //}

        //setting property values thru a public function
        public void propertySetters()
        {
            ESal = 50000;
            City = "Pune";
        }
        #region
        public void DictionaryInitializers()
        {
            //before 6.0 we were initializing as below
            Dictionary<string, string> emp = new Dictionary<string, string>()
            {
                {"Rajesh","Emp100" },
                {"Suresh","Emp009" },
                {"Mukesh" ,"Emp005"}
            };
            //with 6.0 we can initialize as below
            Dictionary<string, string> empdir = new Dictionary<string, string>()
            {
                ["Varsha"] = "Emp001",
                ["Sairoopa"] = "Emp003",
                ["Ramya"] = "Emp001",
            };
            Console.WriteLine("List of Employees");
            foreach (KeyValuePair<string, string> kvp in emp)
            {
                Console.WriteLine($"Name : \t{kvp.Key}\nEmpId :\t{kvp.Value}");
            }
        }
        #endregion
        public void ExceptionFilters()
        {
            try
            {
                int n = 10;
                int res = 10 / n;
                int[] arr = new int[3];
                arr[5] = 20;
                Console.WriteLine("Everything went off well..");
            }
            catch(DivideByZeroException)when(DateTime.Now.DayOfWeek==DayOfWeek.Wednesday)
            {
                Console.WriteLine("It is Thursday Today");
            }
            catch(DivideByZeroException de)when(de.GetType().ToString()==
            "System.DivideByZeroException")
            {
                DoSomething();
            }
            catch(IndexOutOfRangeException)when(DateTime.Now.DayOfWeek ==DayOfWeek.Wednesday)
            {
                Console.WriteLine("Handling exception when it is not a wednesday");
            }
        }

        public static void DoSomething()
        {
            Console.WriteLine("A new Job is getting Done...");
        }
        

    }
    class Program :Employee
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            //Console.WriteLine(e.Ename + e.ESal+e.City);
            //e.Ename = "Bennett";
            //e.propertySetters();
            ////e.City = "Pune"; //not possible
            
            Program p = new Program();
            //p.City = "Mumbai";
            //Console.WriteLine(e.Ename + e.ESal+e.City);
            //    p.DictionaryInitializers();
           e.ExceptionFilters();
            Console.Read();
        }
    }    
}
