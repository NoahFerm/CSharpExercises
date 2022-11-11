using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    internal class Wolfman : Wolf, IPerson
    {

        public Wolfman(string name, int age, int weight, bool sharpFangs) : base(name, age, weight, sharpFangs)
        {
        }

        
        public string Talk()
        {
            return "I'm a werewolf";
        }
        
    }
}
