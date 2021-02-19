

using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("This is the help for calculating");
            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    char assigmentChoice = char.Parse(Console.ReadLine().ToUpper() ?? "Type in one character (1,2,3,4).");
                    switch (assigmentChoice)
                    {
                        case '1':
                            AdditionLoop();
                            break;

                        case '2':
                            SubtractionLoop();
                            break;

                        case '3':
                            Multiplying();
                            break;

                        case '4':
                            Division();
                            break;

                        default:
                            Console.WriteLine("That is not a valid character (1,2,3,4)!");
                            Console.ResetColor();
                            break;
                    }






                    {
                        Console.WriteLine("Division with zero is not possible. Please try again");

                    }

                }


                catch

                {
                    Console.WriteLine("Ttype in one character (1,2,3,4) for calcul method and hit return.");
                }

            }
            static double AskUserForInput(string what = "a number")
            {
                Console.Write($"Ok, hit me with {what}..  ");
                double ret = Double.Parse(Console.ReadLine());
                return ret;
            }
            static void Addition()
            {
                Console.WriteLine("Addition");
                double userInput1 = AskUserForInput();
                double userInput2 = AskUserForInput("another number");
                double sum = userInput1 + userInput2;
                Console.WriteLine($"Sum is: {sum}");
            }
            static void AdditionLoop()
            {
                Console.WriteLine("Addition");
                double sum = AskUserForInput();

                bool loopAlive = true;
                while (loopAlive)
                {
                    double userInput2 = AskUserForInput("another number");
                    sum = sum + userInput2;
                    Console.WriteLine($"Sum is (now): {sum}. Give me a letter to quit.");
                }
            }

            static void Subtraction()
            {
                Console.WriteLine("Subtraction");
                double userInput1 = AskUserForInput();
                double userInput2 = AskUserForInput("a number to subtract from the first number");
                double sum = userInput1 - userInput2;
                Console.WriteLine($"Sum is: {sum}");
            }
            static void SubtractionLoop()
            {
                Console.WriteLine("Subtraction");
                double sum = AskUserForInput();

                bool loopAlive = true;
                while (loopAlive)
                {
                    double userInput2 = Math.Abs(AskUserForInput("Another number;) "));
                    sum = sum - userInput2;
                    Console.WriteLine($"Sum is (now): {sum}. Give me a letter to quit.");
                }
            }

            static void Multiplying()
            {
                double userInput1 = AskUserForInput();
                double userInput2 = AskUserForInput("a number to multiply with the first number");
                double sum = userInput1 * userInput2;
                Console.WriteLine($"Product is: {sum}");
            }
            static void Division()
            {
                double userInput1 = AskUserForInput("a number as numerator");
                double userInput2 = AskUserForInput("a number as denominator.this number must not be ZERO!");
                if (userInput2 != 0)
                {
                    double q = userInput1 / userInput2;
                    Console.WriteLine($"Quota is: {q}");
                }
                else
                {
                    Console.WriteLine("Division with zero is not possible. Pls try again");
                }

            }


        }
    }
}


































