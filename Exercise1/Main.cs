using Exercise1.Helpers.MenuHelpers;
using Exercise1.Helpers;
using Exercise1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Main
    {
        private readonly IUI ui;
        private readonly IPayRoll payRoll;
        public Main( IUI ui, IPayRoll payRoll)
        {
            this.ui = ui;
            this.payRoll = payRoll;
        }
        public void Run()
        {
            SeedData();

            do
            {
                ShowMainMenu();
                string input = ui.GetInput()!;

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

        private void AddEmployee()
        {
            string name = Util.AskForString("Name", ui);
            uint salary = Util.AskForUInt("Salary", ui);

            payRoll.AddEmployee(name, salary);

            //Create new employee
        }

        private void PrintEmployees()
        {
            List<Employee> employees = payRoll.GetEmployees();

            foreach (Employee employee in employees)
            {
                ui.Print(employee.ToString());

            }
        }

        private void ShowMainMenu()
        {
            ui.Print($"{MenuHelpers.Add}. Add employee");
            ui.Print($"{MenuHelpers.Print}. Show employees");
            ui.Print($"{MenuHelpers.Quit}. Quit");
        }

        private void SeedData()
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
}
