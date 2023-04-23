using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int percentageFromUser = int.Parse(percentage);

        string letter = "";

        if (percentageFromUser >= 90)
        {
            letter = "A";
        }
        else if (percentageFromUser >= 80)
        {
            letter = "B";
        }
        else if (percentageFromUser >= 70)
        {
            letter = "C";
        }
        else if (percentageFromUser >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percentageFromUser >= 90 || percentageFromUser < 60)
        {
            Console.WriteLine($"You have an: {letter}");
        }
        else
        {
            Console.WriteLine($"You have a: {letter}");
        }

        if (percentageFromUser >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Please continue to turn in assignments to improve your grade.");
        }
    }
}