using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    internal class Dog : Animal
    {
        private string breed;
        public string Breed { get { return breed; } set { breed = value; } }

        public Dog(string name, int age, int weight, string breed) : base(name, age, weight)
        {
            Breed = breed;
        }

        public override string DoSound()
        {
            return "Woof!";
        }
    }
}
