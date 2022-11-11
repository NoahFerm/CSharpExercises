using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    abstract class Animal
    {
        //If all animals need one more attribute thats the same for all animals, add it to Animal
        private string name;
        private int age;
        private int weight;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public abstract string DoSound();

        public Animal(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
    }
}
