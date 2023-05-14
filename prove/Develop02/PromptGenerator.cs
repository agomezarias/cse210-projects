using System;

public class Prompts
{
    public List<string> journalPrompts = new List<string>();

    public Prompts()
    {
        journalPrompts.Add("What did I accomplish today that made a difference?");
        journalPrompts.Add("Did I attempt to meet someone new today?");
        journalPrompts.Add("What made you feel angry today?");
        journalPrompts.Add("What made you feel happy today?");
        journalPrompts.Add("What event occured that I want to remember?");
    }

    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(journalPrompts.Count);

        return journalPrompts[index];

    }
}