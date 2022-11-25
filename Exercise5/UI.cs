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
                Console.WriteLine("1) Create new garage");
                Console.WriteLine("2) Display vehicles");
                Console.WriteLine("3) Park vehicle");
                Console.WriteLine("4) Remove vehicles");
                Console.WriteLine("0) Quit");
                input = Console.ReadLine();
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
    }
}