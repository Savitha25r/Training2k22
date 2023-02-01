using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project
{
    class DataLayer : IProducts
    {
        public string InsertProducts()
        {
            string str = "DI... Injected";
            Console.WriteLine(str);
            return str;
        }
    }
}
