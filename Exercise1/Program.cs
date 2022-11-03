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

namespace Exercise1
{
    internal class Program
    {


       static PayRoll payRoll = new PayRoll();
        static void Main(string[] args)
        {
            


            SeedData();

            do
            {
                ShowMainMenu();
                string input = Console.ReadLine()!;

                switch (input)
                {
                    case MenuHelpers.Add:
                        AddEmployee();
                        break;
                    case MenuHelpers.Print:
                        PrintEmployees();
                        break;
                    case MenuHelpers.Quit:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } while (true);

        }

        private static void AddEmployee()
        {
            string name = Util.AskForString("Name");
            uint salary = Util.AskForUInt("Salary");

            payRoll.AddEmployee(name,salary);
            
            //Create new employee
        }

        private static void PrintEmployees()
        {
            List<Employee> employees = payRoll.GetEmployees();

            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
                
            }
        }

        private static void ShowMainMenu()
        {
            Console.WriteLine($"{MenuHelpers.Add}. Add employee");
            Console.WriteLine($"{MenuHelpers.Print}. Show employees");
            Console.WriteLine($"{MenuHelpers.Quit}. Quit");
        }

        private static void SeedData()
        {
            payRoll.AddEmployee("Anna", 36000);
            payRoll.AddEmployee("Bengt", 30000);
            payRoll.AddEmployee("Pelle", 4000);
            payRoll.AddEmployee("Lars", 60000);
            payRoll.AddEmployee("Karl", 3000);
            payRoll.AddEmployee("Tim", 35000);
        }
    }
}