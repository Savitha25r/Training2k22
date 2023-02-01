using System;
using System.Collections;

namespace Day9Dotnet
{
    class CollectionEg
    {
        public void ArrayListEg()
        {
            //ArrayList Collection can take different data types
            ArrayList arrlist = new ArrayList();
            arrlist.Add("Sampreeth");
            arrlist.Add(10);
            arrlist.Add(true);
            arrlist.Add(35.45f);
            arrlist.Add('S');
            arrlist.Add(55.50);
           
            foreach(var val in arrlist)
            {
                Console.WriteLine(val);
            }

            //insert a value at an index
            arrlist.Insert(2, "Rama");
           // arrlist.Remove(10); //or
            arrlist.RemoveAt(1);
            Console.WriteLine("--------------");
            foreach (var val in arrlist)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("----------");
            Console.WriteLine(arrlist.Capacity);
            //another arraylist object
            ArrayList newlist = new ArrayList();
            newlist.Add(1);
            newlist.Add(8);
            newlist.Add(19);
            newlist.Add(6);
            newlist.Add(4);

            arrlist.InsertRange(0,newlist);
            Console.WriteLine("----after adding a range of values----");
            Console.WriteLine(arrlist.Count);
            Console.WriteLine(arrlist.Capacity);
            
            foreach (var val in arrlist)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("************");
            foreach (int i in newlist)
            {
                Console.WriteLine(i);
            }
            newlist.Sort();
            foreach(int i in newlist)
            {
                Console.WriteLine(i);
            }
        }

        public void HashTableEg()
        {
            Hashtable ht = new Hashtable();
            ht.Add("E002", "Aishwarya");
            ht.Add("E008", "Raajesh");
            ht.Add("E003", "Brahmaji");
            ht.Add("E001", "Tejaswi");
            ht.Add(10, "Anushree");
            ht.Add("E100", null);
            ht.Add("E005", "Tejaswi");
           //iterate thru the keys
           foreach(var s in ht.Keys)
            {
                Console.WriteLine(s);
            }
            //iterate thru values
            foreach (var s in ht.Values)
            {
                Console.WriteLine(s);
            }
            //in order to iterate the entire object to get both keya and values
            //we need to use an variable of DictionaryEntry structure
            foreach(DictionaryEntry de in ht)
            {
                Console.Write(de.Key + " ");
                Console.Write(de.Value);
                Console.WriteLine();
            }
            //Hashtables are used for serach operations
            Console.WriteLine("---------------");
            Console.WriteLine("Enter a Key to Search:");
            string empid = Console.ReadLine();
            if(ht.ContainsKey(empid))
            {
                Console.WriteLine(empid + " =" +ht[empid]);
            }
            else
                Console.WriteLine(empid  + "Does not exists");
        }

        public void SortedListEg()
        {
            SortedList slist = new SortedList();
            slist.Add("ora", "Oracle");
            slist.Add("vb", "Visual Basic");
            slist.Add("cs", "CSharp");
            slist.Add("asp", "ASP.net");

            foreach(DictionaryEntry d in slist)
            {
                Console.Write(d.Key + " " + d.Value);
                Console.WriteLine();
            }
        }

        public void StacksEg()
        {
            Stack st = new Stack();
            st.Push("AA");
            st.Push(2);
            st.Push('S');
            foreach(object o in st)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(st.Peek());
            st.Pop();
            Console.WriteLine(st.Peek());
            foreach (object o in st)
            {
                Console.WriteLine(o);
            }
        }
        public static void Main()
        {
            CollectionEg ceg = new CollectionEg();
            // ceg.ArrayListEg();
            // ceg.HashTableEg();
            //ceg.SortedListEg();
            ceg.StacksEg();
            Console.Read();
        }
    }
}
