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

namespace Exercise1
{
    internal class Program
    {
        //public class employees
        //{
            static void Main(string[] args)
            {
                string[] employees = new string[] { };


                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter salary: ");
                string salary = Console.ReadLine();
                string employee = String.Concat(name, " ", salary);
                employees = employees.Concat(new string[] { employee }).ToArray();
                Console.WriteLine(employees.ToString());
                /*
                bool showMenu = true;
                while (showMenu)
                {
                    showMenu = Menu();
                }*/
                
            }
        /*
            private static bool Menu()
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. See the register");
                Console.WriteLine("2. Add Employee");  
                Console.WriteLine("3. Exit");

                string name = "";
                string salary = "";

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Employees register: ");
                        Console.WriteLine("{0} : {1}", name, salary);
                        return true;
                    case "2":
                        Console.WriteLine("Enter name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter salary: ");
                        salary = Console.ReadLine();
                        Console.WriteLine("Added {0} with {1} kr salary to the register!", name, salary);

                        return true;
                    case "3":
                        return false;
                    default:
                        return true;
                }
            }*/
        //}
       
    }
}