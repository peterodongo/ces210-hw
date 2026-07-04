using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Display the welcome message
        DisplayWelcome();

        // 2. Call the function to get the user's name and save it to a variable
        string userName = PromptUserName();

        // 3. Call the function to get the user's favorite number and save it to a variable
        int userNumber = PromptUserNumber();

        // 4. Call the function to square the user's number and save it to a variable
        int squaredNumber = SquareNumber(userNumber);

        // 5. Call the function to display the final result by passing the name and squared number
        DisplayResult(userName, squaredNumber);
    }

    // Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Asks for and returns the user's name as a string
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Asks for and returns the user's favorite number as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Accepting an integer as a parameter and returning that number squared as an integer
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // Accepting the user's name and the squared number and displays them.
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}