
using Exercise3;
using Exercise3.Animals;
using Exercise3.InputErrors;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Person noah = new Person("Noah", "Ferm", 20, 165, 55);
            PersonHandler.SetAge(noah, 30);
            Console.WriteLine(noah.DisplayPerson());

            Person noah2 = new Person("Noah2", "Ferm2");
            Console.WriteLine(noah2.DisplayPerson());

            Person noah3 = PersonHandler.CreatePerson("Noah3", "Ferm3", 20, 165, 55);
            PersonHandler.SetAge(noah3, 40);
            Console.WriteLine(noah3.DisplayPerson());





            Horse horse = new Horse("Raven", 10, 300, 85);
            Dog dog = new Dog("Hero", 5, 30, "Golden retriever");
            Hedgehog hedgehog = new Hedgehog("Sonic", 1, 0, true);
            Worm worm = new Worm("Jim", 0, 0, true);
            Bird bird = new Bird("Rex", 0, 0, true);
            Wolf wolf = new Wolf("Knight", 0, 0, true);
            Penguin penguin = new Penguin("Pingu", 0, 0, false, true);
            Wolfman wolfman = new Wolfman("Zev", 0, 0, true);

            Console.WriteLine($"Horse: {horse.Name}");
            Console.WriteLine($"Speed: {horse.Speed} km/h");
            Console.WriteLine(horse.DoSound());

            Console.WriteLine($"Dog: {dog.Name}");
            Console.WriteLine($"Breed: {dog.Breed}");
            Console.WriteLine(dog.DoSound());

            Console.WriteLine($"Hedgehog: {hedgehog.Name}");
            Console.WriteLine($"Is cute: {hedgehog.IsCute}");
            Console.WriteLine(hedgehog.DoSound());

            Console.WriteLine($"Worm: {worm.Name}");
            Console.WriteLine($"Is on a fishing hook: {worm.IsOnFishingHook}");
            Console.WriteLine(worm.DoSound());

            Console.WriteLine($"Penguin: {penguin.Name}");
            Console.WriteLine($"It's Pingu? {penguin.IsPingu}");
            Console.WriteLine(penguin.DoSound());

            Console.WriteLine($"Wolf: {wolf.Name}");
            Console.WriteLine($"Sharp fangs? {wolf.SharpFangs}");
            Console.WriteLine(wolf.DoSound());

            Console.WriteLine($"Wolfman: {wolfman.Name}");
            Console.WriteLine($"Sharp fangs? {wolfman.SharpFangs}");
            Console.WriteLine(wolfman.DoSound());
            Console.WriteLine(wolfman.Talk());





            List<UserError> errors = new List<UserError>();
            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());
            errors.Add(new EmptyInputError());
            errors.Add(new OutsideOfRangeInputError());
            errors.Add(new WeirdInputError());
            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
        }
    }
}