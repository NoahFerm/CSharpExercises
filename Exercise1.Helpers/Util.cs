using Exercise1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Helpers
{
    public static class Util
    {
        public static string AskForString(string prompt, IUI ui)
        {
            string answer;
            bool success = false;
            do
            {
                ui.Print($"{prompt}: ");
                answer = ui.GetInput()!;

                if (string.IsNullOrWhiteSpace(answer))
                {
                   ui.Print($"You must enter a valid {prompt}");
                }
                else
                {
                    success = true;
                }
            } while (!success);
            return answer;
        }

        public static uint AskForUInt(string prompt, IUI ui)
        {
            do
            {
                string input = AskForString(prompt, ui);


                if(uint.TryParse(input, out uint answer))
                {
                    return answer;
                }

            } while (true);
        }
    }
}
