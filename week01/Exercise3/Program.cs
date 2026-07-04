using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // 101 is exclusive, so it picks 1-100

            // Initialize a guess counter
            int guessCount = 0;
            int guess = -1; // Initializing a temporary value that won't match the magic number

            Console.WriteLine("\nI have picked a magic number between 1 and 100. Try to guess it!");

            // Loop keeps going as long as the guess doesn't match
            while (guess != magicNumber)
            {
                // Ask the user for a guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                
                // Increment of the count for every guess made
                guessCount++;

                // Determine higher, lower, or correct
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
                }
            }

            // Inform user of how many guesses it took
            Console.WriteLine($"It took you {guessCount} guesses.");

            // Ask to play again
            Console.Write("\nDo you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thank you for playing! Goodbye.");
    }
}