using System;
using Microsoft.Practices.Unity;

namespace DI_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating unity container object
            UnityContainer uc = new UnityContainer();

            //register all relevant types
           // uc.RegisterType<BusinessLayer>();
           // uc.RegisterType<DataLayer>();
            uc.RegisterType<IProducts, DataLayer>();
            uc.RegisterType<IOrders, OrdersClass>();
            BusinessLayer bl = uc.Resolve<BusinessLayer>();
            
            bl.Insert();
            Console.Read();
        }
    }
}
