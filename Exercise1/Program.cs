//class employee
//namn och lön

/*
 1. Enter name
 2. Enter salary
 3. Put in object as {name , salary}
 4. Add to array [{name , salary},{name , salary}]
 5. Show register as a for loop that prints each object in a line each. 
    A loop that replays depending on how many items in the array, i < employees.Length
 6. Make object into a string each. Take the values from the object employees[i] 
    and put them together as a string
    Console.WriteLine() for each loop.
*/

using Exercise1.Helpers;
using Exercise1.Helpers.MenuHelpers;
using Exercise1.UI;

namespace Exercise1
{
    internal class Program
    {



        static void Main(string[] args)
        {
            IPayRoll payRoll = new PayRoll();
            IUI ui = new ConsoleUI();

            Main main = new Main(ui, payRoll);
            main.Run();

        }
            
    }
}