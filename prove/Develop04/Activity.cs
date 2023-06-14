using System;

public class Activity
{
    private string _activityName = "";
    private string _description = "";
    private int _activityDuration;
    // private string _readyAnimation;    DECIDED I DIDNT NEED THIS
    // private string _finishAnimation;   DECIDED I DIDNT NEED THIS


    public Activity(string name, string description, int seconds)
    {
        _activityName = name;
        _description = description;
        _activityDuration = seconds;
        // _readyAnimation = duration;   DECIDED I DIDNT NEED THIS
        // _finishAnimation = finished;  DECIDED I DIDNT NEED THIS
    }

    //These are the Getters for the private member variables.
    public string GetActivityName()
    {
        return _activityName;
    }

    public string SetName(string name)
    {
        _activityName = name;
        return name;   
    }

     public void DisplayIntro()
    {
        Console.Clear();
        Console.Write($"Welcome to the {_activityName}.");
        Console.WriteLine();
    }

    public string GetDescription()
    {
        return _description;
    }

    public string SetDescription(string description)
    {
        _description = description;
        return description;
    }

    public void DisplayDescription()
    {
        Console.WriteLine();
        Console.WriteLine(_description);
    }

   public string InitialDescription(string description)  //Individual activity escriptions.
    {
        description = "";
        return description;
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public int SetActivityDuration(int seconds)
    {
        _activityDuration = seconds;
        return seconds;
    }

    //Readkey() method
    //https://www.geeksforgeeks.org/console-readkey-method-in-c-sharp/
    public void DurationInSeconds()
    {
        Console.WriteLine();
        Console.Write($"Press any key to start this activity. It will take approimately {_activityDuration} seconds.");
        Console.ReadKey();
    }
        
    public void DisplayReadyMessage()
    {
        Console.Clear();
        Console.WriteLine("Get Ready....");
        PauseShowSpinner(5);
    }

    public void YouMayBegin(int countDownNum)
    {
        Console.Write("You may begin in: ");
        PauseShowCountdown(countDownNum);
        Console.WriteLine();
    }

    public void DisplayFinishAnimation()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!!");
        PauseShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName}.");
        PauseShowSpinner(3);
    }
    
    public void PauseShowCountdown(int countDownNum)
    {
        for (int i = countDownNum; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void PauseShowSpinner(int time)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("| ");
        animationStrings.Add("/ ");
        animationStrings.Add("- ");
        animationStrings.Add("\\ ");
        animationStrings.Add("| ");
        animationStrings.Add("/ ");
        animationStrings.Add("- ");
        animationStrings.Add("\\ ");


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(400);
            Console.Write("\b\b");

            i++;

            if (i >= animationStrings.Count)
            {

                i = 0;
            }

        }

        //USED EXAMPLE FROM WEB. FORGOT TO REFERENCE.
        Console.Write(new string(' ', animationStrings[animationStrings.Count - 1].Length));
        Console.SetCursorPosition(Console.CursorLeft - animationStrings[animationStrings.Count - 1].Length, Console.CursorTop);

    }

}












//Inheritance Help
//https://www.programiz.com/csharp-programming/inheritance


//THESE THINGS DIDNT WORK AND I HAVE THEM HERE IN CASE I 
//NEED TO USE THEM OR SEE WHAT I HAVE ALREADY TRIED.

// public string GetReadyAnimation()
    // {
    //     return _readyAnimation;
    // }

    // public string SetReadyAnimation(string ready)
    // {
    //     _readyAnimation = ready;
    //     return ready;
    // }


// public string GetFinishAnimation()
    // {
    //     return _finishAnimation;
    // }

    // public string SetFinishAnimation(string finish)
    // {
    //     _finishAnimation = finish;
    //     return finish;
    // }


// public void ReadyAnimation(string ready)
// {
    
//     _readyAnimation = ready;
//     // Console.WriteLine("Get ready...");
//     Console.WriteLine(ready.);
    
// }

// FOR THE DURATIONINSECONDS THAT DID NOT WORK. 
// Console.WriteLine("How long, in seconds, would you like your session to be?");

        // string input = Console.ReadLine(); 
        // int seconds = int.Parse(input);
        
        // int seconds;
        // if (int.TryParse(input, out seconds))
        // {
        //     Console.WriteLine("Invalid... Please enter an integer.");
        // }

        // return seconds;



//TRIED TO DO FAST MOVING PERIODS FOR LOADING BUT I COULDNT 
//GET IT TO GO BACK ON THE CONSOLE TO THE BEGINNING. 

        // animationStrings.Add(". ");
        // animationStrings.Add(" . ");
        // animationStrings.Add("   . ");
        // animationStrings.Add("    . ");
        // animationStrings.Add("     . ");
        // animationStrings.Add("      . ");
        // animationStrings.Add("       . ");
        // animationStrings.Add("        . ");



        // List<string> completedAnimation = new List<string>();
        // completedAnimation.Add(" ");




// Console.WriteLine("How long, in seconds, would you like your session to be?");
//         string _activityDuration = Console.ReadLine();
//         int time = 
//         return 