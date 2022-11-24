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
        private Handler handler = new Handler();
        private readonly UI ui = new UI();
        private bool runApp;
        

        internal void Start()
        {
            Run();
        }

        private void Run()
        {
            runApp = true;
            Garage<Vehicle> garage;
            do
            {
                garage = handler.CreateGarage(10);
                handler.SeedData(garage);
                handler.GaragePrinter(garage);
            } while (runApp);
            
        }

        

    }
}
