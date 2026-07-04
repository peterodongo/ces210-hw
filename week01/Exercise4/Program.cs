using System;
using System.Collections.Generic; // Required to use Lists
using System.Linq;        // Required for easy mathematical list extensions (.Sum, .Average, .Max)

class Program
{
    static void Main(string[] args)
    {
        // Creating a list to store the integers entered by the user
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int userNumber = -1;

        // Loop to collect numbers until user enters 0
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            // Only appending the number if it is NOT 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

       
        
        // 1. Computing the sum
        int sum = numbers.Sum();

        // 2. Computing the average (using double to get the decimal places)
        double average = numbers.Average();

        // 3. Finding the largest number
        int max = numbers.Max();

        // Print  results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        
        // Initialize with a placeholder value (max value possible) to look for lower positive items
        int smallestPositive = int.MaxValue; 
        bool foundPositive = false;

        foreach (int num in numbers)
        {
            // Check if it's positive (> 0) and smaller than our current smallest tracked candidate
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
                foundPositive = true;
            }
        }

        if (foundPositive)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Sorting the numbers and displaying the list 
        // Using a built-in 'Sort' method to arrange them from lowest to highest
        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}