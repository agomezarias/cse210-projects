using System;

public class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _timesCompleted = 0;
    private int _bonusScore;
    private bool _isComplete = false;


public ChecklistGoal(string goalType, string name, string description, int score, 
int timesToComplete, int timesCompleted, int bonusScore, bool isComplete) : base(goalType, name, description, score)
{
    _goalType = "Checklist Goal";
    _timesToComplete = timesToComplete;
    _timesCompleted = timesCompleted;
    _bonusScore = bonusScore;
    _isComplete = isComplete; 
}

public int GetTimesToComplete()
{
    return _timesToComplete;
}

public int SetTimesToComplete(int timesToComplete)
{
    _timesToComplete = timesToComplete;
    return _timesToComplete;
}

public int AskTimesToComplete()
{
    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
    string toCompleteInput = Console.ReadLine();

    int _timesToComplete = int.Parse(toCompleteInput);
    return _timesToComplete;
}

public int GetTimesCompleted()
{
    return _timesCompleted;
}

public bool IsComplete()
{
    return _isComplete;
}

public int SetTimesCompleted(int timesCompleted)
{
    _timesCompleted = timesCompleted;
    return _timesCompleted;
}

public void TotalCompleted()
{
    _timesCompleted = _timesCompleted + 1;
}

public int GetBonusScore()
{
    return _bonusScore;
}

public int SetBonusScore(int bonusScore)
{
    _bonusScore = bonusScore;
    return _bonusScore;
}

public int AskBonusAmount()
{
    Console.Write("What is the bonus for accomplishing it that many times? ");
    string toBonusInput = Console.ReadLine();

    int _bonusScore = int.Parse(toBonusInput);
    return _bonusScore;
}



public override string GetGoalString()// Making a goal string made it easier to work with.
                                      // This Runs the Checklist Goal as well as returns values.
    {
        string _goalType = GetGoalType();
    
        string _name = AskGoalName();
        SetGoalName(_name);
        
        string _description = AskGoalDescription();
        SetGoalDescription(_description);
        
        int _score = AskGoalScore();
        SetScore(_score);
        
        int _timesToComplete = AskTimesToComplete();
        SetTimesToComplete(_timesToComplete);

        int _timesCompleted = GetTimesCompleted();
        SetTimesCompleted(_timesCompleted);
        
        int _bonusScore = AskBonusAmount();
        SetBonusScore(_bonusScore);

        string checklistGoalString = $"{_goalType}: {_name}: {_description}: {_score}: {_timesToComplete}: {_timesCompleted}: {_bonusScore}";

        return checklistGoalString;
    }

public override void ListTheGoal(int i)//Returns as the demo does.
    {
        if (IsComplete() == false)
        {
            Console.WriteLine($"{i}. [ ]  {GetGoalName()} ({GetGoalDescription()}) -- Currently completed:{_timesCompleted}/{_timesToComplete}");
        }

        else if (IsComplete() == true)
        {
            Console.WriteLine($"{i}. [X]  {GetGoalName()} ({GetGoalDescription()}) -- Completed:{_timesCompleted}/{_timesToComplete}");
        }
    }
public override void RecordEvent(List<Goal> goals)
    {
        TotalCompleted();
        int _score = GetGoalScore();
        int _bonusScore = GetBonusScore();

        if (_timesCompleted == _timesToComplete)// when the set amount is completed, give bonus.
        {
            _isComplete = true;
            _score = _score + _bonusScore;
            Console.WriteLine($"Congratulations!! You have earned {_score} points.");
        }

        else
        {
            Console.WriteLine($"Congratulations!! You have earned {GetGoalScore()} points.");
        }

    }

    public override string SaveGoal()//Save Checklist Goals in this order.
    {
        return $"{GetGoalType()}: {GetGoalName()}: {GetGoalDescription()}: {GetGoalScore()}: {GetTimesCompleted()}: {GetTimesToComplete()}: {GetBonusScore()}: {IsComplete()}";
    }

    public override string LoadGoal()
    {
        return $"{GetGoalType()}: {GetGoalName()}: {GetGoalDescription()}: {GetGoalScore()}: {GetTimesCompleted()}: {GetTimesToComplete()}: {GetBonusScore()}: {IsComplete()}";
    }
}