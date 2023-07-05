using System;

public class EternalGoal : Goal
{
    private bool _isComplete = false;//Always false for Eternal Goal.

    public EternalGoal(string goalType, string name, string description, 
    int score, bool isComplete) : base(goalType, name, description, score)
    {
        _goalType = "Eternal Goal";
        _isComplete = isComplete;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }


    public override string GetGoalString()// Making a goal string made it easier to work with.
                                          // This Runs the Eternal Goal as well as returns values.
    {
        string _goalType = GetGoalType();

        string _name = AskGoalName();
        SetGoalName(_name);

        string _description = AskGoalDescription();
        SetGoalDescription(_description);
        
        int _score = AskGoalScore();
        SetScore(_score);
        
        string eternalGoalString = $"{_goalType}: {_name}: {_description}: {_score}: {_isComplete}";

        return eternalGoalString;
    }


    public override void ListTheGoal(int i)//Made it return like the video did. 
    {
         Console.WriteLine($"{i}. [ ]  {GetGoalName()} ({GetGoalDescription()})");
    }


    public override void RecordEvent(List<Goal> goals)
    {
        Console.WriteLine($"Congratulations!! You have earned {GetGoalScore()} points.");
        _isComplete = false;
    }


    public override string SaveGoal()//Save Eternal Goals in this order.
    {
        return $"{GetGoalType()}: {GetGoalName()}: {GetGoalDescription()}: {GetGoalScore()}: {IsComplete()}";
    }

    public override string LoadGoal()
    {
        return $"{GetGoalType()}: {GetGoalName()}: {GetGoalDescription()}: {GetGoalScore()}: {IsComplete()}";
    }

    
}
