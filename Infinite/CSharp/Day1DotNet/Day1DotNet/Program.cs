using System;


namespace Day1DotNet
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello All !!.. Welcome to the Dot Net Training");
            Program program = new Program();
            //int result=program.Add2nos(5, 10);
            //Console.WriteLine(result);
            Console.WriteLine(Add2nos(10, 10));
            TestClass tc = new TestClass();
          //  tc.Show();
            tc.accept();
            tc.Show();
           // TestClass tc2 = new TestClass();
           // tc2.Show();
            TestClass.Message();            
            Console.ReadKey();
        }

        static int Add2nos(int x, int y)
        {
            return x + y;
        }
    }

    class TestClass
    {
        int age;  //integral datatype - instance field
        string name;  //reference data types
        static string companyname="Infinite";  //class level field
       

         public void Show()
        {
            Console.WriteLine(age + " " + name +" "+companyname); //concatenation
            Console.WriteLine("Name is :{0} Age is :{1} and Company Name is :{2}",name,age,companyname); //place holder
           Console.WriteLine($"Name is {name}, Age is {age},Company name is {companyname}");
        }

        public void accept()  // instance method
        {
            Console.WriteLine("Enter age and name :");
            age=Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            companyname = Console.ReadLine();
        }

        public static string Message()  //static method are maintained at class level
        {
            return "Hello";
        }
    }
}
