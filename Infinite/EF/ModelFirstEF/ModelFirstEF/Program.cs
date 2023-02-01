using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstEF
{
    class Program
    {
        static Model1Container db = new Model1Container();
        static void Main(string[] args)
        {
            //var product = new Product
            //{
            //   // ProductId = 100,
            //    Name="A4",
            //    Price=12,
            //    QOH=80
            //};
            //db.Products.Add(product);
            //db.SaveChanges();

            var plist = from p in db.Products
                        orderby p.Price descending
                        select p;

            foreach(var item in plist)
            {
                Console.WriteLine(item.ProductId +  " " + item.Name+ " "+item.Price+" "+ item.QOH);
            }
            Console.Read();
        }
    }
}
