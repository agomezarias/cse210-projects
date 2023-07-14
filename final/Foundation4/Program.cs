using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        List<Activity> activities = new List<Activity>()
        {
            new Running(new DateTime(2020, 1, 20), 45, 4),

            new Cycling(new DateTime(1991, 12, 11), 60, 10),

            new Swimming(new DateTime(2019, 6, 20), 30, 40)

        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetActivitySummary());
        }
    }

}