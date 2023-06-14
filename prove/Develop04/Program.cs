using System;

class Program
{
    static void Main(string[] args)
    {
        //Source help for creating a simple menu.
        //https://wellsb.com/csharp/beginners/create-menu-csharp-console-application/
        bool generateMenu = true;
        while (generateMenu)
        {
            int menuSelection = Menu.MainMenu();

            if (menuSelection == 1)
            {
                //Breating Activity
                BreathingActivity breathing = new BreathingActivity("","",60,"","");
                
                breathing.RunBreathingActivity();

            }

            else if ( menuSelection == 2)
            {
                //Reflection Activity
                ReflectionActivity reflecting = new ReflectionActivity("", "", 75, "", "");
                reflecting.RunReflectionActivity();
                
            }

            else if ( menuSelection == 3)
            {
                //Listing Activity
                ListingActivity listing = new ListingActivity("","",60,"");
                listing.RunListingActivity();

            }
            
            else if ( menuSelection == 4)
            {
                //Reflection Activity
                generateMenu = false;
                Console.WriteLine("I hope to see you again. Have a good day!!");
            }

            else
            {
                generateMenu = false;
                Console.WriteLine("PLEASE ENTER A VALID NUMBER....");
                Thread.Sleep(3000);
                generateMenu = true;
                
            } 
        }

        return;

    }
}





























        //                                 Program Summary:
//In this program, The main program will run in a loop until the user decides to quit. The program will display a console menu which will contain four excersice options to choose from. The options will be to do a breathing activity,to do a reflecting activity, to do a listing activity, or to quit. The breathing activity will help change the midset of the user to one of relaxation through a brief breathing exercise. The reflecting excercise will help the user in strengthening their mentality by having them reflect on difficult times in their life where they were able to persevere. Finally, the listing activity will help the user by allowing them to list and ponder good moments in their life  so that they may continue to have meaning and purpose on their life journey. The program will contain one Base Activity class that the other 3 Activity classes can inherit from. There will be a menu class to handle the menu display, and a prompts class that will handle 2 lists. One list for prompts to be randomly returned and one list for questions to be randomly returned.  
    
        // Activity breathing1 = new Activity("Breathing,",)
        // Console.WriteLine(DurationInSeconds());

//THESE THINGS WERE USED WHILE TESTING FOR WRITING THE RUNBREATHINGACTIVITY()

// breathing.DisplayIntro();
                // breathing.DisplayDescription();
                // breathing.DurationInSeconds();
                // int duration = breathing.DurationInSeconds();
                // DateTime startTime = DateTime.Now;
                // DateTime endTime = startTime.AddSeconds(int.Parse(duration));

                // while (DateTime.Now < endTime)
                // {

                // }