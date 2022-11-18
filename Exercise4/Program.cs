using System;
using System.Collections;
using System.Diagnostics;

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
                Console.WriteLine("\n\nPlease navigate through the menu by inputting the number \n(1, 2, 3, 4, 0) of your choice"
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

            //Capacity fördubblas varje gång Count == Capacity
            //Det slösar nog inte mycket minne av att duplicera med 2 jämfört med att plussa på en
            //capacity för varje gång det blir fullt
            //Capacity minskar inte när man tar bort items i listan
            //Om man ska lägga till och ta bort mycket så är det enklast att använda lista, och den
            //har mer funktionalitet
            //Arrays har också en förbestämd size, medans lista är mer flexibel
            //Arrays används mycket vid string hantering

            bool running = true;
            List<string> theList = new List<string>();
            while (running)
            {
                Console.WriteLine($"\n\n0 to quit.\n+(value) to add.\n-(value) to remove.\nThe list({theList.Count}, {theList.Capacity}):");
                //Prints the list
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
                        //Adds the input to the list
                        theList.Add(value);
                        break;
                    case '-':
                        //Removes the input from the list
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
            bool running = true;
            Queue theQueue = new Queue();
            while (running)
            {
                Console.WriteLine($"\n\n0 to quit.\n+(value) to add.\n- to remove.\nThe queue({theQueue.Count}):");
                //Prints the queue
                foreach (var item in theQueue)
                {
                    Console.WriteLine(item);
                }
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        //Adds the input to the queue
                        theQueue.Enqueue(value);
                        break;
                    case '-':
                        //Removes the first item in the queue
                        theQueue.Dequeue();
                        break;
                    case '0':
                        running = false;
                        break;
                }
            }
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

            //ICA kön är inte bra med en stack för att så länge det kommer nya i kön så kommer de
            //som kom innan behöva vänta tills de som kom efter har gått innan de kan gå själva.
            bool running = true;
            Stack theStack = new Stack();
            while (running)
            {
                Console.WriteLine($"\n\n0 to quit.\n+(value) to add.\n- to remove.\nThe stack({theStack.Count}):");
                //Prints the stack
                foreach (var item in theStack)
                {
                    Console.WriteLine(item);
                }
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        string reversedValue = ReverseText(value);
                        //Adds the input to the stack
                        theStack.Push(reversedValue);
                        break;
                    case '-':
                        //Removes the latest item in the stack
                        theStack.Pop();
                        break;
                    case '0':
                        running = false;
                        break;
                }
            }
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            //bool running = true;
            //Creates a stack
            Stack<char> stack = new Stack<char>();
            //while (running)
            //{
                Console.WriteLine($"0 to quit.\nEnter parathensises: ");
                string input = Console.ReadLine();
                //If you input 0, quit the method, otherwise continue I want to keep
                //running the method until the user inputs 0, but I'll return to that
                switch (input)
                {
                    case "0":
                        //running = false;
                        return;
                }
                //Loops until it has either decided it's incorrect or it has gone through
                //all characters without finding any problems
                for (int i = 0; i < input.Length; i++)
                {
                    //makes a char out of the first character of the input
                    char character = input[i];
                    //If char is an opening paranthesis, adds it to the stack
                    if (character == '(' || character == '{' || character == '[')
                    {
                        stack.Push(character);
                    }
                    //If its a closing paranthesis...
                    else if (character == ')' || character == '}' || character == ']')
                    {
                        //..and the stack is empty, there are no opening tags that needs closing,
                        //and therefore it's incorrect
                        if (stack.Any() == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Paranthesis is incorrect");
                            Console.ForegroundColor = ConsoleColor.White;
                            return; 
                        }
                        //If the character is a closing paranthesis and the stack has any opening
                        //paranthesis
                        else
                        {
                            switch (character)
                            {
                                //Checks if the closing paranthesis matches the latest opening
                                //paranthesis. If it doesn't match it's incorrect. Ex. (]
                                case ')':
                                    if (stack.Pop() != '(')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Paranthesis is incorrect");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        return;
                                    } 
                                    break;
                                case '}':
                                    if(stack.Pop() != '{')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Paranthesis is incorrect");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        return;
                                    }
                                    break;
                                case ']':
                                    if(stack.Pop() != '[')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Paranthesis is incorrect");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        return;
                                    }
                                    break;
                            }
                        }
                    }
                }
                //If there are no paranthesis in the stack it means they were
                //all matched with a closing paranthesis, therefore correct
                if (!stack.Any())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Paranthesis is correct");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                //If there are still paranthesis in the stack, it means some
                //weren't closed and therefore its incorrect
                else if (stack.Any())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Paranthesis is incorrect");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                //This will only run of none of the paths are run
                Console.WriteLine("Invalid input. Please enter paranthesis");
            //}
        }
        static string ReverseText(string value)
        {
            Stack stack = new Stack();
            string reversed = "";
            
            for (int i = 0; i < value.Length; i++)
            {
                stack.Push(value[i]);
            }
            while(stack.Count > 0)
            {
                reversed += stack.Pop().ToString();
            }

            //Reverses too
            //foreach (var item in stack)
            //{
            //    reversed += item;
            //}
            return reversed;
        }

    }
}
