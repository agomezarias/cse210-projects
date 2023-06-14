using System;

public class ListingActivity : Activity
{    
    DateTime startTime = DateTime.Now;
    private string _listingPrompt;
    private List<string> _userListingResponse = new List<string>();

    public ListingActivity(string name, string description, int seconds,
    string listingPrompt) : base(name, description, seconds)
    {
        _listingPrompt = listingPrompt;
    }

    public string GetListingPrompt()
    {
        Prompts listingPrompt = new Prompts();
        string _listingPrompt = listingPrompt.GetRandomListingPrompt();
        Console.WriteLine($"-- {_listingPrompt} --");
        return _listingPrompt;
    }

    public string SetListingPrompt(string listingPrompt)
    {
        _listingPrompt = listingPrompt;
        return listingPrompt;
    }

    public void AllowListCreation()
    {
        Console.WriteLine("Enter a list of responses. (Press Enter after each response. Type end to stop listing.)");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(30);
       
       
        while (DateTime.Now < endTime)
        {
            // Thread.Sleep(1000);
            string input = Console.ReadLine();

            
            if (input.ToLower() != "end")
            {
    
                _userListingResponse.Add(">" + input);

            }
        }
       
        // This code will not exit upon reaching 30 seconds but it will if a new input is returned.
        // I had trouble this whole project with the DATE TIME PARTS. I will continue work towards
        // improving ont the date and time in c#.
 
    }

    public void ListingPromptMessage()
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt... You will have 30 seconds to do so.");
        Console.WriteLine();
        GetListingPrompt();
        Console.WriteLine();
        YouMayBegin(9);
    }

    public void RunListingActivity()
    {
        SetName("Listing Activity");
        Console.Clear();
        DisplayIntro();
        SetDescription("This activity will have you make a list that will help you remember and ponder good moments in you life so that you may continue to have meaning and purpose in your own journey.");
        DisplayDescription();
        DurationInSeconds();
        Console.Clear();
        DisplayReadyMessage();
        ListingPromptMessage();
        AllowListCreation();
        DisplayFinishAnimation();
    }

}








// public void DisplayListingPrompt()
    // {
    //     GetListingPrompt();
    //     Console.WriteLine($"-- {_lisitingPrompt} --");
    // }

    // public string ListingUserResponses()
    //     {
    //         Console.WriteLine(">");
    //     }