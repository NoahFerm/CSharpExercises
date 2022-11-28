using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private int Capacity { get; set; }
        private T[] garage;
        public Garage(int capacity)
        {
            this.Capacity = Math.Max(capacity, 1);
            garage = new T[capacity];
        }

        public virtual bool Add(T vehicle)
        {
            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i] == null)
                {
                    garage[i] = vehicle;
                    return true;
                }
            }
            Console.WriteLine("Garage is full");
            return false;
        }
        //public virtual bool Remove(string reg)
        //{
        //    if (!garage.Any())
        //        Console.WriteLine("Garage is empty");
        //    garage.Where(v => v.RegNumber == reg)
        //        .Select(v => v.DisplayInfo());
        //}

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in garage)
            {
                //..
                if (vehicle is not null)
                    yield return vehicle;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
