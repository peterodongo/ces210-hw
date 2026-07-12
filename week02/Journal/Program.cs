using System;

class Program
{

    static void Main(string[] args)
    {

        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while(running)
        {


            Console.WriteLine();

            Console.WriteLine("Journal Menu");

            Console.WriteLine("1. Write a new entry");

            Console.WriteLine("2. Display journal");

            Console.WriteLine("3. Save journal");

            Console.WriteLine("4. Load journal");

            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch(choice)
            {
                
                case "1":
                   
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine();

                    Console.WriteLine(prompt);

                    Console.Write("> ");


                    string response = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();


                   
                    Entry newEntry = new Entry(
                        date,
                        prompt,
                        response
                    );


                   
                    journal.AddEntry(newEntry);

                    Console.WriteLine("Entry added successfully.");

                    break;

                
                case "2":

                    journal.DisplayAll();

                    break;

                case "3":

                    Console.Write("Enter filename: ");

                    string saveFile = Console.ReadLine();

                    journal.SaveToFile(saveFile);

                    break;

               
                case "4":

                    Console.Write("Enter filename: ");

                    string loadFile = Console.ReadLine();

                    journal.LoadFromFile(loadFile);

                    break;

                
                case "5":
                    running = false;

                    Console.WriteLine("Goodbye!");

                    break;

                
                default:

                    Console.WriteLine("Invalid option. Please try again.");

                    break;

            }

        }

    }

}