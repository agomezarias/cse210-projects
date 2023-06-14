using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentDateTime = DateTime.Now;
        string entryDate = currentDateTime.ToShortDateString();

        
        bool exitJournal = false;

        List<JournalEntry> entries = new List<JournalEntry>();

        Console.WriteLine("\n");

        Console.WriteLine("  Welcome to the Daily Journal!");
        
        while (!exitJournal)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Please select from the following:");
            Console.WriteLine("1. New Journal Entry.");
            Console.WriteLine("2. Display Journal.");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Exit Journal Program");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("What is your selection?");
            string userMenuSelection = Console.ReadLine();


            if (userMenuSelection == "1")
            {
                Prompts journalPrompts = new Prompts();
                string currentPrompt = journalPrompts.RandomPrompt();
                
                Console.WriteLine(currentPrompt);
                string userPromptResponse = Console.ReadLine();
                
                JournalEntry newEntry = new JournalEntry
                {
                    currentPrompt = currentPrompt,
                    userPromptResponse = userPromptResponse,
                    entryDate = entryDate
                };

                entries.Add(newEntry);
            }


            else if (userMenuSelection == "2")
            {
                foreach (JournalEntry entry in entries)
                {
                    Console.WriteLine("Date: " + entry.entryDate);
                    Console.WriteLine("The Prompt was: " + entry.currentPrompt);
                    Console.WriteLine("Your Response was: " + entry.userPromptResponse);
                }
            }


            else if (userMenuSelection == "3")
            {
                entries = Load.ReadFromFile();
            }

            
            else if (userMenuSelection == "4")
            {
                Save.SaveToFile(entries);
            }


            else if (userMenuSelection == "5")
            {
                exitJournal = true;
                Console.WriteLine("!!Have a good rest of your day!!");
            }

        }
        return;
    }
}