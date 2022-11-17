using System;

/*
 Question 1. How does the stack and heap work?
    The stack is like a pile of boxes stacked on each other, it has an executive order 
    in which it operates on. It has to lift the boxes at the top in order to reach the 
    ones at the bottom, once it is done with a box, it throws it away

 Question 2. What are value types and reference types? What differentiates them?
    Value types are variables that hold a value while reference types are variables 
    that point to where the value is located and you reach that value by using the 
    reference type variable.
Question 3. Why does the first method return 3 and the second returns 4?
    The second one uses a new instance of a class MyInt. A class is a reference type, x 
    is an object, also a reference type and points to where the value is stored on the heap.
    Meanwhile the first method declares the variables within the method, on the stack. The 
    variables will be removed once the method is finished with them.
    Value types will be on the stack unless they're in an instance field of a class.
    
    public int ReturnValue()
    {
        int x = new int();          <- Creates new instance of int for some reason      
        x = 3;                      <- x's value is 3
        int y = new int();          <- Creates new instance of int
        y = x;                      <- Puts the same value in y as in x
        y = 4;                      <- Changes the value of y to 4
        return x;                   <- x's value didnt change because int is not a reference type
    }                               If we change x after y = x, y won't change. 
                                    With y = x, we make a copy of x's current value and put it in y.

    public int ReturnValue2()
    {
        MyInt x = new MyInt();      <- Creates instance of MyInt (class) and stores the reference in x
        x.MyValue = 3;              <- Sets MyValue for the instance to 3
        MyInt y = new MyInt();      <- Creates instance of MyInt and stores the reference in y
        y = x;                      <- Switches the reference of y to point to the same instance as x
        y.MyValue = 4;              <- Changes MyValue of the instance that both x and y points to.
        return x.MyValue;           <- returns 4 because MyInt is a class, x is an object, both are reference types
    }                               If we change x.MyValue after y = x, y.MyValue will also change.
                                    x doesn't hold the value itself but containt the path to the value within its
                                    instance of MyInt, which contains the property of MyValue which contains the 
                                    actual value. 
                                    After y = x, both of them contain the reference to the same instance.
 */

namespace Exercise4
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3, 4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            
            bool running = true;
            List<string> theList = new List<string>();
            while (running)
            {
                Console.WriteLine($"Press Q to quit.\nThe list({theList.Count}, {theList.Capacity}):");
                //Capacity fördubblas varje gång Count == Capacity
                //Det slösar nog inte mycket minne av att duplicera med 2 jämfört med att plussa på en
                //i capacity för varje gång det blir fullt
                //Capacity minskar inte när man tar bort items i listan
                //Om man ska lägga till och ta bort mycket så är det enklast att använda lista, och den
                //har mer funktionalitet
                //Arrays har också en förbestämd size, medans lista är mer flexibel
                //Arrays används mycket vid string hantering
                foreach (var item in theList)
                {
                    Console.WriteLine(item);
                }
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        break;
                    case '0':
                        running = false;
                        break;
                }
            }






        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}
