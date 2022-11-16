using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    internal class Penguin : Bird
    {
        private bool isPingu;

        public bool IsPingu { get { return isPingu; } set { isPingu = value; } }

        public Penguin(string name, int age, int weight, bool canFly, bool IsPingu) : base(name, age, weight, canFly)
        {
            IsPingu = isPingu;
        }

        public override string DoSound()
        {
            return "Noot noot!";
        }

        public override string Stats()
        {
            return base.Stats() + $"Is Pingu? {IsPingu}";
        }
    }
}

