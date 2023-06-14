using System;

public class Prompts
{
    private List<string> _reflectionPrompts = new List<string>();
    protected List<string> _listingPrompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Prompts()
    {
        //ReflectionActivity Prompts 
        _reflectionPrompts.Add("Think of a time when you stood up for someone else.");
        _reflectionPrompts.Add("Think of a time when you did something really difficult.");
        _reflectionPrompts.Add("Think of a time when you helped someone in need.");
        _reflectionPrompts.Add("Think of a time when you did something truly selfless.");

        //ListingActivity Prompts
        _listingPrompts.Add("Who are people that you appreciate?");
        _listingPrompts.Add("What are personal strengths of yours?");
        _listingPrompts.Add("Who are people that you have helped this week?");
        _listingPrompts.Add("When have you felt the Holy Ghost this month?");
        _listingPrompts.Add("Who are some of your personal heroes?");

       //ReflectionQuestions
       _questions.Add("Why was this experience meaningful to you?");
       _questions.Add("Have you ever done anything like this before?");
       _questions.Add("How did you get started?");
       _questions.Add("How did you feel when it was complete?");
       _questions.Add("What made this time different than other times when you were not as successful?");
       _questions.Add("What is your favorite thing about this experience?");
       _questions.Add("What could you learn from this experience that applies to other situations?");
       _questions.Add("What did you learn about yourself through this experience?");
       _questions.Add("How can you keep this experience in mind in the future?");

    }


    //Random Prompt for use with the Reflection Activity Class
    public string GetRandomReflectionPrompt()
    {
        Random random = new Random();
        int index = random.Next(_reflectionPrompts.Count);

        return _reflectionPrompts[index];
    }


    //Random Question for use with the Reflection Activity Class.
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);

        return _questions[index];
    }


    //Random Prompt for use with the Listing Activity Class
    public string GetRandomListingPrompt()
    {
        Random random = new Random();
        int index = random.Next(_listingPrompts.Count);

        return _listingPrompts[index];
    }
}