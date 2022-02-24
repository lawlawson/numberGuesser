using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Lawrence";

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("What is your name?");

            string input = Console.ReadLine();

            Console.WriteLine("$Hello{0}, let's play a game", input);

        }
    }
}
