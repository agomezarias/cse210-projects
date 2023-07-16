using System;

class Program
{
    static void Main(string[] args)
    {
        //EVENT 1: LECTURE

        Address address1 = new Address("2345 florence St", "aurora", "Co", "80010", "USA");
        
        Lecture lecture1 = new Lecture("Learning C#", "Short and informative gathering for learning C#.", 
        "01/28/2021", "10:00AM", address1, "Jimmy Smith", 250);
        
        
        //EVENT 2: RECEPTION

        Address address2 = new Address("2319 Jasmine St", "Denver", "CO", "80247", "US");
        
        Reception reception1 = new Reception("Mr. and Mrs. James Wedding Reception", 
        "Join us as we celebrate a start to our new marriage surrounded by our closest friends and family", 
        "10/23/2023", "5:00PM", address2, "YES");

        
        //EVENT 3: OUTDOOR GATHERING

        Address address3 = new Address("Independencia 952", "Jalisco", "GDL", "44200", "MX");

        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Villa Family Summer BBQ",
        "Come join us as we celebrate our family legacy. It will be a day full of story telling, carnival games, and so much more.", 
        "07/31/2023", "2:00PM to 10:00PM", address3, "91");


        //DISPLAY EACH EVENT WITH RELATED INFO.
        Event[] events = {lecture1, reception1, outdoorGathering1};

        Console.WriteLine("Marketing Messages:");

        foreach (Event type in events)
        {
            Console.WriteLine();
            Console.WriteLine("Standard Details:");
            Console.WriteLine(type.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("Full Details:");
            Console.WriteLine(type.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine("Short Description:");
            Console.WriteLine(type.GetShortDescription());
        }
    }
}

        //TESTING EACH TYPE OF EVENT. REPLACED WITH FOREACH

        // Console.WriteLine("Marketing Messages:");
        // Console.WriteLine();
        // Console.WriteLine("Standard Details:");
        // Console.WriteLine(lecture1.GetStandardDetails());
        // Console.WriteLine();
        // Console.WriteLine("Full Details:");
        // Console.WriteLine(lecture1.GetFullDetails());
        // Console.WriteLine();
        // Console.WriteLine("Short Description:");
        // Console.WriteLine(lecture1.GetShortDescription());



        // Console.WriteLine("Marketing Messages:");
        // Console.WriteLine();
        // Console.WriteLine("Standard Details:");
        // Console.WriteLine(reception1.GetStandardDetails());
        // Console.WriteLine();
        // Console.WriteLine("Full Details:");
        // Console.WriteLine(reception1.GetFullDetails());
        // Console.WriteLine();
        // Console.WriteLine("Short Description:");
        // Console.WriteLine(reception1.GetShortDescription());



        // Console.WriteLine("Marketing Messages:");
        // Console.WriteLine();
        // Console.WriteLine("Standard Details:");
        // Console.WriteLine(outdoorGathering1.GetStandardDetails());
        // Console.WriteLine();
        // Console.WriteLine("Full Details:");
        // Console.WriteLine(outdoorGathering1.GetFullDetails());
        // Console.WriteLine();
        // Console.WriteLine("Short Description:");
        // Console.WriteLine(outdoorGathering1.GetShortDescription());