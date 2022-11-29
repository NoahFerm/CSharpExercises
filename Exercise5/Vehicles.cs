using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    abstract class Vehicle
    {
        public string RegNumber { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }

        public Vehicle (string regNumber, string color, int numberOfWheels)
        {
            RegNumber = regNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
        }

        public virtual string DisplayInfo()
        {
            return $"Vehicle: {this.GetType().Name}\tReg: {RegNumber}\tColor: {Color}\tNumber of wheels: {NumberOfWheels}";
        }
    }
    internal class Car : Vehicle
    {
        public Car(string registerNumber, string color, int numberOfWheels) : base(registerNumber, color, numberOfWheels) { }
    }
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string registerNumber, string color, int numberOfWheels) : base(registerNumber, color, numberOfWheels) { }
    }
    
}
