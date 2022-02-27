﻿using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Lawrence";

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);

            while(true) { 

            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            int initGuess = 0;

            Console.WriteLine("Guess a number between 1 and 10");


            while(initGuess != correctNumber)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out initGuess))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine("Please enter a valid number");

                    Console.ResetColor();

                    continue;
                }

                initGuess = Int32.Parse(input);

                if (initGuess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine("Wrong number please try again");

                    Console.ResetColor();
                }


            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("You are CORRECT!!!");

            Console.ResetColor();

            Console.WriteLine("Play again [Y or N]");

            string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }



            }

        }
    }
}
