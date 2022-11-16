using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    internal class Wolfman : Wolf, IPerson
    {
        private bool supernaturalStrength;
        public bool SupernaturalStrength { get { return supernaturalStrength; } set { supernaturalStrength = value; } }
        public Wolfman(string name, int age, int weight, bool sharpFangs, bool supernaturalStrength) : base(name, age, weight, sharpFangs)
        {
        }

        
        public string Talk()
        {
            return "I'm a werewolf";
        }

        public override string Stats()
        {
            return base.Stats() + $", Supernatural strength? {SupernaturalStrength}";
        }
    }

}

