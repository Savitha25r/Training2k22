using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Dotnet
{
    class Engine
    {        
        internal protected string Engine_Features;

        public string Make { get; set; }
        public Double EnginePower { get; set; }
       
        public Engine(string make, double power, string features)
        {
            Make = make;
            EnginePower = power;
            Engine_Features = features;
        }
    }

    class Car
    {
        //fields of class car         
        string Model;        
        Engine eng;//composition
        public Car(string model, string make, double pow, string f)
        {
            Model = model;
            eng = new Engine(make, pow,f);
            //eng.Make = e.Make;
            //eng.EnginePower = e.EnginePower;
            //eng.Engine_Features = e.Engine_Features;
        }
        public void ShowCar()
        {            
            Console.WriteLine($"{Model}, {eng.Make},{eng.EnginePower},{eng.Engine_Features}");
        }

    }
    class RelationTypes
    {
       static void Main()
        {
            //creating object of car and instatntiating engine properties 
            Car mycar = new Car("SUV", "Maruthi", 100, "Excellent");
            mycar.ShowCar();
            Console.ReadLine();
        }
    }
}
