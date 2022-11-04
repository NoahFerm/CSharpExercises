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
                    "1. Cinema ticket(s)\n" +
                    "2. Repeat 10 times\n" +
                    "3. The third word");

                switch (Console.ReadLine())
                {
                    case "0":
                        showMenu = false;
                        break;
                    case "1":
                        TotalCostTickets();
                        break;
                    case "2":
                        RepeatTenTimes();
                        break;
                    case "3": 
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }

            } while (showMenu);
        }

        private static void RepeatTenTimes()
        {
            Console.WriteLine("Write something: ");
            string input = Console.ReadLine()!;

            for (int i = 0; i < 11; i++)
            {
                Console.Write($"{i + 1}. {input} ");
            }
            Console.WriteLine();
        }

        private static void TotalCostTickets()
        {
            bool notSuccessful = true;
            string inputAmountOfPeople;
            int totalCost = 0;
            int price;
            int juniorTickets = 0;
            int standardTickets = 0;
            int seniorTickets = 0;
            
            do
            {
                Console.WriteLine("How many tickets?");
                inputAmountOfPeople = Console.ReadLine()!;
               
                //See if its a number
                if (int.TryParse(inputAmountOfPeople, out int amountOfPeople))
                {
                    notSuccessful = false;

                    //Repeat loop for every person to calculate and add all their costs
                    for (int i = 0; i < amountOfPeople; i++)
                    {
                        price = SingleTicket();
                        totalCost += price;

                        switch (price)
                        {
                            case 80:
                                juniorTickets++;
                                break;
                            case 90:
                                seniorTickets++;
                                break;
                            default:
                                standardTickets++;
                                break;
                        }
                        
                        //Total cost when all have entered their ages
                        if (i == amountOfPeople - 1)
                        {
                            string stringJuniorTickets = "";
                            string stringStandardTickets = "";
                            string stringSeniorTickets = "";

                            if(juniorTickets > 0)
                                stringJuniorTickets = $"{juniorTickets} Junior Ticket(s).";
                            if (standardTickets > 0)
                                stringStandardTickets = $"{standardTickets} Standard Tickets(s).";
                            if (seniorTickets > 0)
                                stringSeniorTickets = $"{seniorTickets} Senior Ticket(s).";

                            Console.WriteLine($"{totalCost} kr for {amountOfPeople} ticket(s). {stringJuniorTickets} {stringStandardTickets} {stringSeniorTickets}\nEnjoy the movie!");
                        }
                    }
                }
                //If input is not a number, force the user to write new input
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            } while (notSuccessful);
        }

        public static int SingleTicket()
        {
            bool notSuccessful = true;
            int cost;
            string input;
            do
            {
                Console.WriteLine("Enter an age: ");
                input = Console.ReadLine()!;

                //Check if input is a number
                if (int.TryParse(input, out int age))
                {
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