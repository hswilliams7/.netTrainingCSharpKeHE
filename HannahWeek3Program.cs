/*
 * C# Program to Perform a Number Guessing Game
 * Hannah S. Williams, 5.23.2022
 */
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> guessList = new List<int>();
            Random random = new Random();

            int returnValue = random.Next(1, 10);

            int Guess = 0;

            Console.WriteLine("Hello! I am thinking of a number between 1-10.  Can you guess what it is?");

            while (Guess != returnValue)
            {

                if (!int.TryParse(Console.ReadLine(), out Guess))
                {
                    Console.WriteLine("Invalid input- please enter numbers only");
                    continue;
                }
                else
                {
                    guessList.Add(Guess);
                }

                if (Guess < returnValue)
                {
                    Console.WriteLine($"No, the number I am thinking of is higher than {Guess}." +
                        "Please try again.");
                }
                else if (Guess > returnValue)
                {
                    Console.WriteLine($"No, the number I am thinking of is lower than {Guess}." +
                        "Please try again.");
                }

            }

            Console.WriteLine($"Well done! The answer is {returnValue}");
            Console.WriteLine("Your guesses were");
            Console.WriteLine(string.Join("\n", guessList.ToArray()));
            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();

        }
    }
}