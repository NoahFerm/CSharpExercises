using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    internal class Wolf : Animal
    {
        private bool sharpFangs;
        public bool SharpFangs { get { return sharpFangs; } set { sharpFangs = value; } }

        public Wolf(string name, int age, int weight, bool sharpFangs) : base(name, age, weight)
        {
            SharpFangs = sharpFangs;
        }

        public override string DoSound()
        {
            return "Awooo!";
        }
    }
}
