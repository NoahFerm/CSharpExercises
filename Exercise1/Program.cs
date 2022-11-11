
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