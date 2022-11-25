using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Handler
    {
        private readonly Garage<Vehicle> garage;

        public Handler(int capacity)
        {

            garage = new Garage<Vehicle>(capacity);
        }

        
        //garage.Add(car);
        //garage.Add(airplane);
        //garage.Add(airplane2);

        //GaragePrinter(garage);
        //Console.ReadLine();
        public bool Test(Vehicle v)
        {
            return v.Color == "Red";
        }

        public IEnumerable<string> GaragePrinter()
        {
            return garage//.Where(v => v.Color == "Red")
                .Select(v => v.DisplayInfo());



            //var res2 = garage.Where(v => Test(v));
            //var res3 = garage.Where(Test);
            //foreach (Vehicle vehicle in garage)
            //{
            //  //  if (vehicle != null)
            //        Console.WriteLine(vehicle.DisplayInfo());
            //}
        }
        public Garage<Vehicle> CreateGarage(int capacity)
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(capacity);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("New garage created!");
            Console.ForegroundColor = ConsoleColor.White;
            return garage;
        }
   

        public void SeedData()
        {
            Vehicle airplane = new Airplane("abc123", "white", 3);
            Vehicle airplane2 = new Airplane("bbc123", "gray", 3);
            Vehicle car = new Car("cbc123", "red", 4);
            garage.Add(airplane);
            garage.Add(airplane2);
            garage.Add(car);
        }

        internal bool Park(Vehicle car)
        {
           return garage.Add(car);
        }
    }
}
