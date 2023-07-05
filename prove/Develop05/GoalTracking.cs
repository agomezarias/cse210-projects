using System;
using System.Collections.Generic;
using System.IO;

public class GoalTracking
{
    private List<Goal> _goals = new List<Goal>();
    private int _scoreTotal;


    public GoalTracking()
    {
        _scoreTotal = 0;
        // scoreTotal = 0;
    }


    public int GetScoreTotal()
    {
        return _scoreTotal;
    }


    public int SetTotalScore(int scoreTotal)
    {
        _scoreTotal = scoreTotal;
        return _scoreTotal;
    }


    public int AddScore(int score)//Get score and add up for total.
    {
        _scoreTotal += score;
        return _scoreTotal;
    }


    // public int AddBonusScore(int bonusScore)//For checklist goal to add the bonus amount.
    // {
    //     _scoreTotal += bonusScore;
    //     return _scoreTotal;
    // }


    public void AddGoal (Goal goal)//Add goal to _goals list.
    {
        _goals.Add(goal);
    }


    public List<Goal> GetGoalList()//Return _goals list.
    {
        return _goals;
    }


    public void ListGoals()// list _goals and index them starting with 1 on display.
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("The goals are:");

            int index = 1;
            foreach (Goal goal in _goals)
            {
                goal.ListTheGoal(index);
                index = index + 1;
                // Console.WriteLine($"{goal.GetGoalName()}: {goal.GetGoalDescription()}");
            }
        }
        else//If no goals in _goals return this.
        {
            Console.WriteLine("No goals found....");
        }
    }


    public void TallyScore()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_scoreTotal} points.");// Show total
        Console.WriteLine();
    }


    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        int recordInput = int.Parse(Console.ReadLine()) -1;

        int goalScore = GetGoalList()[recordInput].GetGoalScore();
        AddScore(goalScore); // Get score and add for total.

        GetGoalList()[recordInput].RecordEvent(_goals);// Add to _goals list - Got help on this section
        
        Console.WriteLine($"You now have {GetScoreTotal()} points.");// Return total     
    }


    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string saveFileName = Console.ReadLine();//will be goals.txt but can be "anything".txt
        

        using (StreamWriter outputFile = new StreamWriter(saveFileName))
        {
            outputFile.WriteLine(GetScoreTotal());// Add up score.
            

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());// Save each goal in _goals list.
            }

        }
    }
    
    public void LoadGoals()
    {
        //Sourced Help: https://stackoverflow.com/questions/43048819/skip-first-line-using-system-io-file-readalllinesfil-in-c-sharp
        //Sourced Help: https://stackoverflow.com/questions/49590754/convert-a-string-to-a-boolean-in-c-sharp#:~:text=3%20Answers&text=OP%2C%20you%20can%20convert%20a,%2F%2F%20Or%20bool%20myBool%20%3D%20Convert.
        //Sourced Help: https://www.youtube.com/watch?v=cST5TT3OFyg
        
        Console.Write("What is the filename for the goal file? ");
        string loadFileName = Console.ReadLine();

        using (StreamReader reader = new StreamReader(loadFileName))
        {
            string t = reader.ReadLine();
            _scoreTotal = Convert.ToInt32(t);
        }
        string[] lines = System.IO.File.ReadAllLines(loadFileName);
        // int scoreTotal = int.Parse(lines[1]);
        lines = lines.Skip(1).ToArray();


        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            
            string _goalType = parts[0];
            string _name = parts[1];
            string _description = parts[2];
            int _score = int.Parse(parts[3]);

            if (_goalType == "Simple Goal")
            {
                // bool _isComplete = Convert.ToBoolean(parts[4]);
                bool _isComplete = bool.Parse(parts[4]);
                SimpleGoal S1 = new SimpleGoal(_goalType, _name, _description, _score, _isComplete);
                AddGoal(S1);
            }

            if (_goalType == "Eternal Goal")
            {
                bool _isComplete = bool.Parse(parts[4]);
                EternalGoal E1 = new EternalGoal(_goalType, _name, _description, _score, _isComplete);
                AddGoal(E1);
            }

            if (_goalType == "Checklist Goal")
            {
                int _timesToComplete = int.Parse(parts[4]);
                int _timesCompleted = int.Parse(parts[5]);
                int _bonusScore = int.Parse(parts[6]);
                bool _isComplete = bool.Parse(parts[7]);
                
                ChecklistGoal C1 = new ChecklistGoal(_goalType, _name, _description, _score, _timesToComplete, _timesCompleted, _bonusScore, _isComplete);
                AddGoal(C1);
            }

        }


    }

}