using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);
        
        DisplayResults(userName, squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();
        int userNumber = int.Parse(favoriteNumber);

        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int squared = userNumber * userNumber;

        return squared;
    }


    static void DisplayResults(string userName, int squared)
    {
        Console.WriteLine($"{userName}, the square of your number is {squared}.");
    }
}