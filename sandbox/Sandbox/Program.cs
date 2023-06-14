using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello Sandbox World!");
        
        Secondary first = new Secondary(0);

        // // Accessing methods of the Secondary class
        // int num = first.GetNum();
        // Console.WriteLine("Current number: " + num);

        // first.SetNum(5);
        // num = first.GetNum();
        // Console.WriteLine("Updated number: " + num);

        first.PauseShowCountdown(5);
    }
}