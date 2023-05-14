using System;

public class Load
{
    public static List<JournalEntry> ReadFromFile()
    {
        Console.WriteLine("Loading previous journal entries.....");
        List<JournalEntry> entries = new List<JournalEntry>();
        string filename = "journal.txt";
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i +=3)
        {
    
            JournalEntry entry = new JournalEntry
                {
                    currentPrompt = lines[0],
                    userPromptResponse = lines[1],
                    entryDate = lines[2]
                };

                entries.Add(entry);

        Console.WriteLine("Code loaded...");
        }
        

        return entries;
    }
}