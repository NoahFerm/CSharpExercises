namespace Exercise5
{
    public class UI
    {
        internal string DisplayMenu()
        {
            bool validInput = false;
            string input;
            do
            {
                Console.WriteLine("Choose one of the following:");
                Console.WriteLine("1) Display vehicles");
                Console.WriteLine("2) Park vehicle");
                Console.WriteLine("3) Remove vehicles");
                Console.WriteLine("4) Insert pre-made vehicles");
                //Console.WriteLine("5) Create new garage");
                Console.WriteLine("0) Quit");
                input = Console.ReadLine()!;
                if (input.Length > 0 )
                {
                    if (input.Length > 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter only one character");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    else if (int.TryParse(input, out int result) == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a number");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    else
                    {
                        validInput = true;
                        return input;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please choose one of the alternatives");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (validInput == false);
            return "";
        }

        internal void Success()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Successful!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        internal void Fail()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Failed!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void Print(string item)
        {
            Console.WriteLine(item);
        }

        internal string Input()
        {
            bool inputEntered = false;
            string input;
            do
            {
                input = Console.ReadLine()!;
                if(input is null || input == "")
                {
                    Console.WriteLine("Enter some input");
                }
                else
                {
                    inputEntered = true;
                    return input;
                }
                    
            } while (inputEntered == false);
            return "";
        }

        
        internal string VehicleSelect()
        {
            bool validInput = false;
            string input;
            do
            {
                Console.WriteLine("Select a vehicle: ");
                Console.WriteLine("1: Car");
                Console.WriteLine("2: Motorcycle");
                input = Input();
                    if (input.Length > 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter only one character");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    else if (int.TryParse(input, out int result) == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a number");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    else
                    {
                        validInput = true;
                        return input;
                    }
            } while (validInput == false);
            return "";
        }
    }
}