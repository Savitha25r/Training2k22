using System;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Day12Dotnet
{
    [Serializable]
    class Customer
    {
       [NonSerialized]
        public string CustId;
        // [DataMember]
        public string Name;
        // [DataMember]
        public string City;

        public string ToJson()
        {
            //make a stream to serialize
            using (MemoryStream stream = new MemoryStream())
            {
                //serialize into the stream
                DataContractJsonSerializer serializer =
                    new DataContractJsonSerializer(typeof(Customer));
                serializer.WriteObject(stream, this);
                stream.Flush();
                //to get the serialized data as text
                stream.Seek(0, SeekOrigin.Begin);
                using(StreamReader reader= new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }            
                    
        }
        public static Customer FromJson(string json)
        {
            //make a stream
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(json);
            writer.Flush();
            stream.Position = 0;

            //deserialize from the stream
            DataContractJsonSerializer serializer =
                new DataContractJsonSerializer(typeof(Customer));
            Customer Cust = (Customer)serializer.ReadObject(stream);
            return Cust;
        }

    }
    class JSONSerialization
    {
        static void Main()
        {
            Customer cust = new Customer() //object Initializer
            {
                CustId="C001",
                Name="Banurekha",
                City="Chennai"
            };

            //call ToJson() for serialization
            string forserialize = cust.ToJson();
            Console.WriteLine(forserialize);

            //calling FromJson() to Deserialize
            Customer new_cust = Customer.FromJson(forserialize);
            Console.WriteLine(new_cust.CustId + " "+new_cust.Name + " "+new_cust.City);
            Console.Read();
        }
    }
}
