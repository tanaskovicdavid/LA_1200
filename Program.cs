using System;

namespace number_guessing_game_Tanaskovic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Random random = new Random();
            bool playAgain = true;
            int guess;
            int numberOfGuesses;
            int randomNumber;
            int min = 1;
            int max = 100;
            String response;

            while (playAgain)
            {
                guess = 0;
                numberOfGuesses = 0;
                response = "";
                randomNumber = random.Next(min, max + 1);
                try
                {
                    while (guess != randomNumber)
                    {
                        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Guess: " + guess);
                        if (guess > randomNumber)
                        {
                            Console.WriteLine(guess + " is too high!");
                            Console.WriteLine();
                        }
                        else if (guess < randomNumber)
                        {
                            Console.WriteLine(guess + " is too low!");
                            Console.WriteLine();
                        }
                        numberOfGuesses++;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Number: " + randomNumber);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("YOU WIN!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Guesses: " + numberOfGuesses);
                    Console.WriteLine("If you want to play again, type \"y\". Else type anything other than y.");
                    response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "Y")
                    {
                        playAgain = true;
                        Console.Clear();
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error. Guess a number between 1 and 100.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("Press any key to close.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}