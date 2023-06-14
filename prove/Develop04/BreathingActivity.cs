using System;

public class BreathingActivity : Activity
{
    private string _breatheIn;
    private string _breatheOut;


    public BreathingActivity(string name, string description, int seconds,
    string breatheIn, string breatheOut) : base(name, description, 
    seconds)
    {
        _breatheIn = breatheIn;
        _breatheOut = breatheOut;
    }

    public string GetBreatheIn()
    {
        return _breatheIn;
    }

    public string SetBreatheIn(string breatheIn)
    {
        _breatheIn = breatheIn;
        return breatheIn;
    }

    public void DisplayBreatheIn(int countDownNum)
    {
        Console.Write("Breathe In....");
        PauseShowCountdown(countDownNum);
    }

    public string GetBreatheOut()
    {
        return _breatheOut;
    }

    public string SetBreatheOut(string breatheOut)
    {
        _breatheOut = breatheOut;
        return breatheOut;
    }

    public void DisplayBreatheOut(int countDownNum)
    {
        Console.Write("Breathe Out....");
        PauseShowCountdown(countDownNum);
    }

    public void BreatheInBreatheOut()
    {
        Console.WriteLine();
        DisplayBreatheIn(3);
        Console.WriteLine();
        DisplayBreatheOut(3);
        Console.WriteLine();
        Console.WriteLine();
        DisplayBreatheIn(4);
        Console.WriteLine();
        DisplayBreatheOut(4);
        Console.WriteLine();
        Console.WriteLine();
        DisplayBreatheIn(5);
        Console.WriteLine();
        DisplayBreatheOut(5);
        Console.WriteLine();
        Console.WriteLine();
        DisplayBreatheIn(6);
        Console.WriteLine();
        DisplayBreatheOut(6);
        Console.WriteLine();
        Console.WriteLine();
        DisplayBreatheIn(7);
        Console.WriteLine();
        DisplayBreatheOut(7);
        Console.WriteLine();
    }

    public void RunBreathingActivity()
    {
        SetName("Breathing Activity");
        Console.Clear();
        DisplayIntro();
        SetDescription("Smile...breathe...and take it slow. Doing this activity will help you to relax.");
        DisplayDescription();
        DurationInSeconds();
        Console.Clear();
        DisplayReadyMessage();
        BreatheInBreatheOut();
        DisplayFinishAnimation();

        //COULD NOT GET PROGRAM TO ONLY GO FOR AS LONG AS THE INPUT WOULD SAY
        //IT WOULD STILL GO FOR THE LENGTH OF THE ENTIRE BREATHING. 

        // int duration = DurationInSeconds();
        // DateTime startTime = DateTime.Now;
        // DateTime endTime = startTime.AddSeconds(duration);
        
        // while (DateTime.Now < endTime)
        // {
        //     break;
        // }

    }
}




















//THESE THINGS DIDNT WORK AND I HAVE THEM HERE IN CASE I 
//NEED TO USE THEM OR SEE WHAT I HAVE ALREADY TRIED.


// public BreathingActivity()
    // {

    // }


    

    // public string GetBreathingActivity(string name)
    // {
    //     name = GetActivityName("Breathing Activity");
    //     return name;
    // }
    
    // public string SetBreathingActivity(string name)
    // {
    //     name = SetName("Breathing Activity");
    //     return name;
    // }

    // public string BreathingDescription()
    // {
        
    //     return GetDescription();
    // }

    // public string SetBreathingDescription(string description)
    // {
    //     description = SetDescription("Smile...breathe...and take it slow. Doing this activity will help you to relax.");
    //     return description;
    // }

    // public void DisplayBreathingDescription(string description)
    // {
    //     Console.WriteLine(description);
    //     // return description;
    // }
