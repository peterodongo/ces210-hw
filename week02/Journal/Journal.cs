using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{

    private List<Entry> _entries = new List<Entry>();



    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }




    public void DisplayAll()
    {

        if(_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }


        foreach(Entry entry in _entries)
        {
            entry.Display();
        }

    }





    public void SaveToFile(string file)
    {

        using(StreamWriter outputFile = new StreamWriter(file))
        {

            foreach(Entry entry in _entries)
            {

                /*
                    manually getting the information
                    from Entry using its methods.
                */
                outputFile.WriteLine(
                    $"{entry.GetDate()}|{entry.GetPromptText()}|{entry.GetEntryText()}"
                );

            }

        }


        Console.WriteLine("Journal saved successfully.");

    }





    public void LoadFromFile(string file)
    {

        _entries.Clear();


        string[] lines = File.ReadAllLines(file);



        foreach(string line in lines)
        {

            string[] parts = line.Split("|");


            string date = parts[0];

            string prompt = parts[1];

            string response = parts[2];



            /*
                Creating Entry using the constructor
                from our new Entry class.
            */

            Entry entry = new Entry(
                date,
                prompt,
                response
            );


            _entries.Add(entry);

        }


        Console.WriteLine("Journal loaded successfully.");

    }


}