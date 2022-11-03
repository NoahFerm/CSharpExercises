using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Helpers
{
    public static class Util
    {
        public static string AskForString(string prompt)
        {
            string answer;
            bool success = false;
            do
            {
                Console.WriteLine($"{prompt}: ");
                answer = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(answer))
                {
                    Console.WriteLine($"You must enter a valid {prompt}");
                }
                else
                {
                    success = true;
                }
            } while (!success);
            return answer;
        }

        public static uint AskForUInt(string prompt)
        {
            do
            {
                string input = AskForString(prompt);


                if(uint.TryParse(input, out uint answer))
                {
                    return answer;
                }

            } while (true);
        }
    }
}
