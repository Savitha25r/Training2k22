using System;
using System.Collections.Generic;

namespace Day9Dotnet
{
    class GenericListEg 
    {
        
        public static void Main()
        {
            GenericListEg gle = new GenericListEg();
            // gle.ListEg();
            gle.DictionaryEg();
            Console.Read();
        }
               
        public void ListEg()
        {
            List<int> intlist = new List<int>();
            intlist.Add(39);
            intlist.Add(13);
            intlist.Add(3);
            intlist.Add(30);
            intlist.Sort();
            foreach (int n in intlist)
            {
                Console.WriteLine(n);
            }
           
            List<string> strlist = new List<string>();
            strlist.Add("Varsha");
            strlist.Add("Divyashree");
            strlist.Add("SaiRoopa");
            strlist.Add("Anupa");

            strlist.Sort();
            foreach (string n in strlist)
            {
                Console.WriteLine(n);
            }
        }
        public void DictionaryEg()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Red");
            dictionary.Add(2, "Blue");
            dictionary.Add(5, "Black");
            dictionary.Add(4, "Orange");
            //iterate thru keys
            foreach(int x in dictionary.Keys)
            {
                Console.WriteLine(x);
            }

            //inorder to get both key and value, use keyvaluepair

            foreach(KeyValuePair<int,string> kvp in dictionary)
            {
                Console.Write(kvp.Key + " ");
                Console.Write(kvp.Value);
                Console.WriteLine();
            }

            Console.WriteLine("Enter the id to retrieve the color");
            int k = Convert.ToInt32(Console.ReadLine());
            if (dictionary.ContainsKey(k))
            {
                Console.WriteLine(k + "represents the color : " +dictionary[k]);
            }
            else
                Console.WriteLine("Id does not exists");
        }
    }
}
