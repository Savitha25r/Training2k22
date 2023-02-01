using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqtoSql_SQLMetal
{
    class Program
    {
        static MyContext db = new MyContext();
        static void Main(string[] args)
        {
            var cat = db.Categories.ToList();

            foreach(var v in cat)
            {
                Console.WriteLine($"{v.CategoryID} {v.CategoryName} {v.Description}");
            }
            Console.Read();
        }
    }
}
