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
                    "1. Adolescent or pensioner\n" +
                    "2. Repeat 10 times\n" +
                    "3. The third word");

                switch (Console.ReadLine())
                {
                    case "0":
                        showMenu = false;
                        break;
                    case "1":
                        AdolescentOrPensioner();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }

            } while (showMenu);
        }

        public static void AdolescentOrPensioner()
        {
            Console.WriteLine("Enter an age: ");
            
                int age = int.Parse(Console.ReadLine());
            
                if (age < 20)
                    Console.WriteLine("Adolescent price: 80 kr");
                else if (age > 64)
                    Console.WriteLine("Pensioner price: 90 kr");
                else 
                    Console.WriteLine("Standard price: 120 kr");

        }
    }
}