using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Handler
    {
        

        //garage.Add(car);
        //garage.Add(airplane);
        //garage.Add(airplane2);

        //GaragePrinter(garage);
        //Console.ReadLine();

        public void GaragePrinter(Garage<Vehicle> array)
        {
            foreach (Vehicle vehicle in array)
            {
                if (vehicle != null)
                    Console.WriteLine(vehicle.DisplayInfo());
            }
        }
        public Garage<Vehicle> CreateGarage(int capacity)
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(capacity);
            return garage;
        }
        public void SeedData()
        {
            Console.WriteLine("You need to create a garage first!");
        }

        public Garage<Vehicle> SeedData(Garage<Vehicle> garage)
        {
            Vehicle airplane = new Airplane("abc123", "white", 3);
            Vehicle airplane2 = new Airplane("bbc123", "gray", 3);
            Vehicle car = new Car("cbc123", "red", 4);
            garage.Add(airplane);
            garage.Add(airplane2);
            garage.Add(car);
            return garage;
        }

    }
}
