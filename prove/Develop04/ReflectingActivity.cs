using System;

public class ReflectionActivity : Activity
{
    private string _reflectPrompts;
    private string _reflectQuestions;
   
   
    public ReflectionActivity(string name, string description, int seconds,
    string reflectPrompt, string reflectQuestion) : base(name, description, seconds)
    {
        _reflectPrompts = reflectPrompt;
        _reflectQuestions = reflectQuestion;
    }

    public string GetReflectionPrompt()
    {
        Prompts reflectPrompt = new Prompts();
        string _reflectPrompts = reflectPrompt.GetRandomReflectionPrompt();
        Console.WriteLine($"--- {_reflectPrompts} ---");
        return _reflectPrompts;
    }

    public string GetReflectionQuestions()
    {
        Prompts reflectQuestions = new Prompts();
        string _reflectQuestions = reflectQuestions.GetRandomQuestion();
        Console.Write($"> {_reflectQuestions}");
        PauseShowSpinner(20);
        return _reflectQuestions;
    }


    public void ReflectionPromptMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        GetReflectionPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, and are ready to begin: Press any key to continue. ");
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        YouMayBegin(7);
    }


    public void RunReflectionActivity()
    {
        SetName("Reflecting Activity");
        Console.Clear();
        DisplayIntro();
        SetDescription("This activity helps you look back on times in your life when you've shown strength and resilience. It enables you to recognize your own power and how you can apply it in different areas of your life.");
        DisplayDescription();
        DurationInSeconds();
        Console.Clear();
        DisplayReadyMessage();
        ReflectionPromptMessage();
        Console.Clear();
        GetReflectionQuestions();
        Console.WriteLine();
        GetReflectionQuestions();
        Console.WriteLine();
        DisplayFinishAnimation();
    }
}