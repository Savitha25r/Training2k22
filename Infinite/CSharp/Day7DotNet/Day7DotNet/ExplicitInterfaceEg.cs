using System;

namespace Day7DotNet
{
    interface IFirst
    {
        void SampleMethod();
    }

    interface ISecond
    {
        void SampleMethod();
    }
    class ExplicitInterfaceEg : IFirst,ISecond
    {
         void IFirst.SampleMethod()
        {
            Console.WriteLine("IFirst Sample method Implementation..");
        }
         void ISecond.SampleMethod()
        {
            Console.WriteLine("ISecond Sample method Implementation..");
        }
        public void SampleMethod(string s)
        {
            Console.WriteLine("My Own Sample Method of " + s);
        }
        public static void Main()
        {
             //fisrt option to access the explicit methods
            IFirst iF = new ExplicitInterfaceEg();
            ISecond iS = new ExplicitInterfaceEg();
            iF.SampleMethod();
            iS.SampleMethod();
            Console.WriteLine("------------");
            //second option to access explicit functions
            ExplicitInterfaceEg ei = new ExplicitInterfaceEg();
            ei.SampleMethod("Interface"); //normal class method
            ((IFirst)ei).SampleMethod(); //interface reference variable
            ((ISecond)ei).SampleMethod();
            Console.Read();            
        }
    }
}
