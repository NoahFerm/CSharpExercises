using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    internal class Worm : Animal
    {
        private bool isOnFishingHook;

        public bool IsOnFishingHook { get { return isOnFishingHook; } set { isOnFishingHook = value; } }

        public Worm(string name, int age, int weight, bool isOnFishingHook) : base(name, age, weight)
        {
            IsOnFishingHook = isOnFishingHook;
        }

        public override string DoSound()
        {
            return "Sad worm noises";
        }
        public override string Stats()
        {
            return base.Stats() + $"Is on fishing hook? {IsOnFishingHook}";
        }
    }
}
