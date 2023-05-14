using System;
using System.Collections.Generic;
using System.IO;

public class Save
{


    public static void SaveToFile(List<JournalEntry> entries)
    {
        Console.WriteLine("Saving to file...");

        string filename = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in entries)
            {
                outputFile.WriteLine(entry.entryDate);
                outputFile.WriteLine(entry.currentPrompt);
                outputFile.WriteLine(entry.userPromptResponse);
            }
        }
    }
}