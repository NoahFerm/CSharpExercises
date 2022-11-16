using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    internal class Horse : Animal
    {
        private int speed;

        public int Speed { get { return speed; } set { speed = value; } }

        public Horse (string name, int age, int weight, int speed) : base(name, age, weight) 
        {
            Speed = speed;
        }

        public override string DoSound()
        {
            return "Neeeeeeigh!";
        }
        public override string Stats()
        {
            return base.Stats() + $"Speed: {Speed}";
        }
    }
}

