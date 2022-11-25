using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Manager
    {
        private Handler handler = null!;
        private readonly UI ui = new UI();
        private bool runApp;
        

        internal void Start()
        {
            //Ask for size
            //loop until ok!
            handler = new Handler(10);

            Run();
        }

        private void Run()
        {
            runApp = true;
            string input;
         //   Garage<Vehicle> garage;

            Console.WriteLine("Welcome to the Garage App!");
            do
            {
                input = ui.DisplayMenu();

                switch (input)
                {
                    case "0":
                        runApp = false;
                        break;
                    case "1":
                        //garage = handler.CreateGarage(10);
                        //handler.SeedData(garage);
                        //if (handler.IsGarageFull)
                        //{

                        //}
                        var car = new Car("ABC123", "RED", 4);

                        if (handler.Park(car))
                        {
                            Console.WriteLine($"Successfully parked {car.GetType().Name}");
                        }
                        break;
                    //case "2":
                    //    handler.GaragePrinter(garage);
                    //    break;
                    default:
                      //  garage = handler.CreateGarage(10);
                        handler.SeedData();
                       IEnumerable<string> stringsToPrint = handler.GaragePrinter();
                        //Print strings
                        break;

                }



            } while (runApp);
            
        }

        

    }
}
