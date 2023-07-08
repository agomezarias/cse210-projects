using System;

public abstract class Goal
{
    protected string _goalType = "";
    private string _name = "";
    private string _description = "";
    private int _score = 0;


    public Goal(string goalType, string name, string description, int score)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _score = score;
    }


    public string GetGoalType()
    {
        return _goalType;
    }


    public string SetGoalType(string goalType)
    {
        _goalType = goalType;
        return goalType;
    }


    public string GetGoalName()
    {
        return _name;
    }


    public string SetGoalName(string name)
    {
        _name = name;
        return name;
    }


    public string AskGoalName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        return _name;
    }


    public string GetGoalDescription()
    {
        return _description;
    }


    public string SetGoalDescription(string description)
    {
        _description = description;
        return description;
    }


    public string AskGoalDescription()
    {
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        return _description;
    }


    public int GetGoalScore()
    {
        return _score;
    }


    public int SetScore(int score)
    {
        _score = score;
        return score;
    }


    public int AskGoalScore()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        string scoreInput = Console.ReadLine();

        int _score = int.Parse(scoreInput);
        return _score;
    }
    
    
    public abstract string GetGoalString();// For getting Goal specific strings
    
    public abstract void ListTheGoal(int i);// Goal specific display

    public abstract void RecordEvent(List<Goal> goals);

    public abstract string SaveGoal();

    public abstract string LoadGoal();

}
