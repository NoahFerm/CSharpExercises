
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

            var animalFarm = new List<Animal>();
            
            animalFarm.Add(new Horse("Raven", 10, 300, 85));
            animalFarm.Add(new Dog("Hero", 5, 30, "Golden retriever"));
            animalFarm.Add(new Hedgehog("Sonic", 1, 0, true));
            animalFarm.Add(new Worm("Jim", 0, 0, true));
            animalFarm.Add(new Bird("Rex", 0, 0, true));
            animalFarm.Add(new Wolf("Knight", 0, 0, true));
            animalFarm.Add(new Penguin("Pingu", 0, 0, false, true));
            animalFarm.Add(new Wolfman("Zev", 0, 0, true, true));


            foreach (var animal in animalFarm)
            {
                Console.WriteLine(animal.Stats());
                Console.WriteLine(animal.DoSound());
                if(animal is IPerson)
                {
                    var temp = animal as IPerson;
                    Console.WriteLine(temp.Talk());
                }

                Console.WriteLine();
            }





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