using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    

    public SimpleGoal(string goalType, string name, string description, int score, 
    bool isComplete) : base(goalType, name, description, score)
    {
        _goalType = "Simple Goal";
        _isComplete = isComplete;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }


    public override string GetGoalString()// Making a goal string made it easier to work with.
                                          // This Runs the Simple Goal as well as returns values.
    {
        string _goalType = GetGoalType();
        
        string _name = AskGoalName();
        SetGoalName(_name);
        
        string _description = AskGoalDescription();
        SetGoalDescription(_description);
        
        int _score = AskGoalScore();
        SetScore(_score);
        
        string simpleGoalString = $"{_goalType}: {_name}: {_description}: {_score}: {_isComplete}";

        return simpleGoalString;
    }

    public override void ListTheGoal(int i)//Returns correctly as the demo does. 
    {

        if (IsComplete() == false)
        {
            Console.WriteLine($"{i}. [ ]  {GetGoalName()} ({GetGoalDescription()})");
            return;
        }

        else if (IsComplete() == true)
        {
            Console.WriteLine($"{i}. [X]  {GetGoalName()} ({GetGoalDescription()})");
            return;
        }

    }

    public override void RecordEvent(List<Goal> goals)
    {
        Console.WriteLine($"Congratulations!! You have earned {GetGoalScore()} points.");        
        _isComplete = true;
    }


    public override string SaveGoal()//Save Simple goals in this order.
    {
        return $"{GetGoalType()}: {GetGoalName()}: {GetGoalDescription()}: {GetGoalScore()}: {IsComplete()}";
    }

    public override string LoadGoal()
    {
        return  $"{GetGoalType()}: {GetGoalName()}: {GetGoalDescription()}: {GetGoalScore()}: {IsComplete()}"; 
    }
}