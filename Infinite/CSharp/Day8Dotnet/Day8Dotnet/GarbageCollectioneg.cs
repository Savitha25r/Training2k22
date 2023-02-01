using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Dotnet
{
    class GarbageCollectioneg : IDisposable
    {
        string s;
        int i;
        float f;
        DateTime dt;
        static void Main()
        {
            GarbageCollectioneg obj;
            obj= new GarbageCollectioneg();
            Console.WriteLine("The number of generations in GC are :{0}",GC.MaxGeneration);
            Console.WriteLine("The generation number of the object is :" + GC.GetGeneration(obj));
            Console.WriteLine("The total Memory :"+ GC.GetTotalMemory(false));
            Console.WriteLine("GC collection in Gen 0 is :" + GC.CollectionCount(0));
            obj.Dispose();
            Console.Read();
        }

        public void Dispose()
        {
            Console.WriteLine("Finalize method is called");            
        }        
    }

}
