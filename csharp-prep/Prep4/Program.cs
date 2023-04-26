using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int newNumbers = -1;

        while (newNumbers != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            string numberFromUser = Console.ReadLine();
            newNumbers = int.Parse(numberFromUser);

            if (newNumbers != 0)
            {
                numbers.Add(newNumbers);
            }

        }
        

        // Sorted numbers list.

        numbers.Sort();


        // Sum up the list.
        
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of the list of numbers is {sum}.");


        // Average of all numbers.

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the list of numbers is: {average}.");

        // Find the largest number in the list.

        int largest = -1000000000;

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largerst number in the list is {largest}.");


        // Find the smallest number in the list that is greater than 0.

        int smallest = 999999999;

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallest)
            {
                smallest = number;
            }
        }

        Console.WriteLine($"The smallest positive number in the list is {smallest}.");


        // Display the list of numbers top to bottom vertically.

        Console.WriteLine("The list of numbers entered in ascending order is: ");

        foreach (int number in numbers) 
        {
            Console.WriteLine(number);
        }
    }
}