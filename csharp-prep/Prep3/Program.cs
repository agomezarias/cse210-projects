using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number? ");
        // string number = Console.ReadLine();
        // int numberFromUser = int.Parse(number);

        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = 0;
        int tries = 0;
        
        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess for the number? ");
            guess = int.Parse(Console.ReadLine());
            tries = tries +1;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! It took you {tries} tries.");
            }
        }
    }
}