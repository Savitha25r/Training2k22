using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project
{
    class BusinessLayer
    {
        IProducts products;
        IOrders orders;

        //injecting the data type object that implements the interface
        public BusinessLayer(IProducts ip, IOrders io) 
        {
            products = ip;
            orders = io;
        }

        public void Insert()
        {
            products.InsertProducts();//this is going to actually call the datalayer.InsertProducts()
                                      // but thru the Iproduct object
            orders.DisplayOrders(); // actual call is to orders.DisplayOrders() thru the 
                                    // IOrders object
        }
    }
}
