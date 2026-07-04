using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for grade percentage
        Console.Write("Please enter your grade percentage: ");
        float grade = float.Parse(Console.ReadLine());
        
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        
        float lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = ""; // No sign if it's between 3 and 6
        }

        // exceptional cases (A+, F+, F-) 
        // no A+, only A and A-
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        
        // no F+ or F-, only F
        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        Console.WriteLine(); // Blank line for clean formatting

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep working hard and you'll get it next time.");
        }
    }
}