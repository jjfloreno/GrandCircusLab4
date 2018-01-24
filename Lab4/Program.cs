using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            bool Exit = false; //used for entire program
            bool AnotherTry = true; //used for running again
            char doAgain; //used when prompted to run again

            while(Exit == false)
            {
                //input
                Console.WriteLine("Welcome to the Factorial Calculator!");
                Console.WriteLine();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Please enter an integer that is greater than 0 but less than 10");

                //validate userInput
                if (int.TryParse(Console.ReadLine(), out userInput) && userInput > 0 && userInput < 10)
                {
                    AnotherTry = true; //assigned to enter while loop when requesting to try again
                    //output, calling the method containing the for loop
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"The factorial of {userInput} is " + CalculateFactorial(userInput));
                }
                else
                {
                    Console.WriteLine("Not a valid input.");
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    System.Threading.Thread.Sleep(500);
                }
                while (AnotherTry == true)
                {
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Would you like to run again? (Y/N)");

                    //validate input
                    if (char.TryParse(Console.ReadLine(), out doAgain))
                    {
                        if (doAgain == 'y' || doAgain == 'Y') //exit this loop if yes
                        {
                            Console.Clear();
                            Console.WriteLine("Here we go!");
                            System.Threading.Thread.Sleep(500);
                            Console.Clear();
                            AnotherTry = false;
                        }
                        else if (doAgain == 'n' || doAgain == 'N') //exit this loop AND outside loop if no
                        {
                            Console.Clear();
                            Console.WriteLine("Goodbye! Press the enter key to exit.");
                            AnotherTry = false;
                            Exit = true;
                            Console.Read();
                        }
                        else //print error message and stay in loop for an unrecognized user input
                        {
                            Console.Clear();
                            Console.WriteLine("Input not understood.");
                            System.Threading.Thread.Sleep(500);
                        }
                    }
                }
            }

        }

        //separate method to get the factorial
        public static long CalculateFactorial(int X)
        {
            int Result = X;
  
            for (int i = 1; i < X; i++)
            {
                Result = Result * i;
            }
            return Result;
        }

        //bonus = RECURSIVE method to get the factorial

    }
}
