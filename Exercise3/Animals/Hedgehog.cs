using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    internal class Hedgehog : Animal
    {
        private bool isCute;

        public bool IsCute { get { return isCute; } set { isCute = value; } }

        public Hedgehog(string name, int age, int weight, bool isCute) : base(name, age, weight)
        {
            IsCute = isCute;
        }

        public override string DoSound()
        {
            return "Ntzz ntzz!";
        }
    }
}
