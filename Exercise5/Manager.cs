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
            IEnumerable<string> stringsToPrint;
         //   Garage<Vehicle> garage;

            Console.WriteLine("Welcome to the Garage App!");
            do
            {
                switch (ui.DisplayMenu())
                {
                    case "0": //Quit App
                        runApp = false;
                        break;
                    case "1": //Display Vehicles
                        stringsToPrint = handler.GaragePrinter();
                        foreach(string item in stringsToPrint)
                        {
                            ui.Print(item);
                        }
                        
                        break;
                    case "2": //Search vehicle
                        var search = ui.Input();
                        stringsToPrint = handler.GaragePrinter(search);
                        foreach (string item in stringsToPrint)
                        {
                            ui.Print(item);
                        }

                        break;
                    case "3": //Park vehicle
                        string reg;
                        string color;
                        int wheels;
                        switch (ui.VehicleSelect())
                        {
                            case "1": //Park car
                                Console.WriteLine("Parking a car");
                                Console.WriteLine("Enter reg number: ");
                                reg = ui.Input();
                                Console.WriteLine("Enter color: ");
                                color = ui.Input();
                                Console.WriteLine("Enter number of wheels: ");
                                if (int.TryParse(ui.Input(), out wheels)) { }
                                else
                                {
                                    ui.Fail();
                                    break;
                                }
                                if (handler.RegisterVehicle("car", reg, color, wheels))
                                    ui.Success();
                                else
                                    ui.Fail();
                                break;
                            case "2": //Park motorcycle
                                Console.WriteLine("Parking a motorcycle");
                                Console.WriteLine("Enter reg number: ");
                                reg = ui.Input();
                                Console.WriteLine("Enter color: ");
                                color = ui.Input();
                                Console.WriteLine("Enter number of wheels: ");
                                if (int.TryParse(ui.Input(), out wheels)) { }
                                else
                                {
                                    ui.Fail();
                                    break;
                                }
                                if (handler.RegisterVehicle("motorcycle", reg, color, wheels))
                                    ui.Success();
                                else
                                    ui.Fail();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "4": //Unpark vehicle
                        stringsToPrint = handler.GaragePrinter();
                        foreach (string item in stringsToPrint)
                        {
                            ui.Print(item);
                        }
                        Console.WriteLine("Unpark vehicle");
                        Console.WriteLine("Enter reg number: ");
                        string parked = ui.Input();
                        stringsToPrint = handler.GaragePrinter(parked);
                        foreach (string item in stringsToPrint)
                        {
                            ui.Print(item);
                        }
                        //handler.Unpark(parked);
                        break;
                    case "5": //Insert pre-made vehicles
                        if (handler.SeedData())
                        {
                            ui.Success();
                        }
                        else { ui.Fail(); }
                        break;
                    default:
                        break;
                }
            } while (runApp);
        }
    }
}
