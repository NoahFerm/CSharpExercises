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
                        TheThirdWord();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }

            } while (showMenu);
        }

        private static void TheThirdWord()
        {
            bool notSuccessful = true;

            do
            {
                Console.WriteLine("Write a sentence (at least 3 words): ");
                var input = Console.ReadLine()!;
                string[] splitString = input.Split(" ");
                
                if (splitString.Length > 2)
                {
                    notSuccessful = false;
                    Console.WriteLine($"The third word is: {splitString[2]}");
                }
                else
                {
                    Console.WriteLine("A longer sentence please.");
                    continue;
                }
            } while (notSuccessful);
        }

        private static void RepeatTenTimes()
        {
            Console.WriteLine("Write something: ");
            string input = Console.ReadLine()!;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Repeated 10 times: {i + 1}. {input}\t");
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
            int freeTickets = 0;
            
            do
            {
                Console.WriteLine("How many tickets?");
                inputAmountOfPeople = Console.ReadLine()!;
               
                //See if its a number
                if (int.TryParse(inputAmountOfPeople, out int amountOfPeople))
                {
                    notSuccessful = false;
                    if(amountOfPeople < 1)
                    {
                        Console.WriteLine("Go away.");
                    }
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
                            case 0:
                                freeTickets++;
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
                            string stringFreeTickets = "";

                            if (juniorTickets > 1)
                                stringJuniorTickets = $"{juniorTickets} Junior Tickets.";
                            if (juniorTickets == 1)
                                stringJuniorTickets = $"{juniorTickets} Junior Ticket.";
                            if (standardTickets > 1)
                                stringStandardTickets = $"{standardTickets} Standard Tickets.";
                            if (standardTickets == 1)
                                stringStandardTickets = $"{standardTickets} Standard Ticket.";
                            if (seniorTickets > 1)
                                stringSeniorTickets = $"{seniorTickets} Senior Tickets.";
                            if (seniorTickets == 1)
                                stringSeniorTickets = $"{seniorTickets} Senior Ticket.";
                            if (freeTickets > 1)
                                stringFreeTickets = $"{freeTickets} Free Tickets.";
                            if (freeTickets == 1)
                                stringFreeTickets = $"{freeTickets} Free Ticket.";

                            Console.WriteLine($"{totalCost} kr for {amountOfPeople} ticket(s). {stringJuniorTickets} {stringStandardTickets} {stringSeniorTickets} {stringFreeTickets}\nEnjoy the movie!");
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
                    if (age < 20 && age >= 5)
                    {
                        cost = 80;
                        Console.WriteLine($"Adolescent price: {cost} kr");
                        return cost;
                    }
                    else if (age > 64 && age < 100)
                    {
                        cost = 90;
                        Console.WriteLine($"Pensioner price: {cost} kr");
                        return cost;
                    }
                    else if (age >= 100)
                    {
                        cost = 0;
                        Console.WriteLine($"Your ticket is free!");
                        return cost;
                    }
                    else if (age < 5)
                    {
                        cost = 0;
                        Console.WriteLine($"Your ticket is free!");
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