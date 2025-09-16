using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
            // Create a random number generator
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // 1 to 100 inclusive

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100...");

            // Game loop
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                guess = int.Parse(input);
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}
