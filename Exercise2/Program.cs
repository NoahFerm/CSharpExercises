using System.Diagnostics.CodeAnalysis;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            do
            {
                Console.WriteLine("Main Menu:\n" +
                    "0. Quit\n" +
                    "1. Cinema ticket 1 person\n" +
                    "2. Cinema ticket several people\n" +
                    "3. Repeat 10 times\n" +
                    "4. The third word");

                switch (Console.ReadLine())
                {
                    case "0":
                        showMenu = false;
                        break;
                    case "1":
                        CinemaOnePersonCost();
                        break;
                    case "2":
                        CinemaSeveralPeopleCost();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }

            } while (showMenu);
        }

        private static void CinemaSeveralPeopleCost()
        {
            bool notSuccessful = true;
            string inputAmountOfPeople;
            int totalCost;
            
            do
            {
                Console.WriteLine("How many of you?");
                inputAmountOfPeople = Console.ReadLine();
               
                if (int.TryParse(inputAmountOfPeople, out int amountOfPeople))
                {
                    //for loop
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                
            } while (notSuccessful);
        }

        public static int CinemaOnePersonCost()
        {
            
            bool notSuccessful = true;
            int cost;
            string input;
            do
            {
                Console.WriteLine("Enter an age: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out int age))
                {
                    age = int.Parse(input);
                    notSuccessful = false;
                    if (age < 20)
                    {
                        cost = 80;
                        Console.WriteLine($"Adolescent price: {cost} kr");
                        return cost;
                    }
                    else if (age > 64)
                    {
                        cost = 90;
                        Console.WriteLine($"Pensioner price: {cost} kr");
                        return cost;
                    }
                    else
                    {
                        cost = 120;
                        Console.WriteLine($"Standard price: {cost} kr");
                        return cost;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            } while (notSuccessful);
            return 0; //Unreachable because of the loop but necessary for avoiding error, smh
        }
    }
}