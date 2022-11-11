using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    internal class Bird : Animal
    {
        //If all birds need one more attribute that's the same for all of them, add it to Bird
        private bool canFly;
        public bool CanFly { get { return canFly; } set { canFly = value; } }

        public Bird(string name, int age, int weight, bool canFly) : base(name, age, weight)
        {
            CanFly = canFly;
        }

        public override string DoSound()
        {
            return "Chirp!";
        }
    }
}
