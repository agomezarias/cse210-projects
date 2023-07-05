using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalTracking goals = new GoalTracking();
        

        bool generateMenu = true;
        while (generateMenu)// Run in loop
        {
            goals.TallyScore();
            int mainMenuSelection = Menus.MainMenu();


            if (mainMenuSelection == 1)
            {
                int goalMenuSelection = Menus.GoalMenu();

                if(goalMenuSelection == 1)
                {
                    Console.WriteLine("Simple Goal Selected");
                    SimpleGoal S1 = new SimpleGoal("", "", "", 0, false);
                    S1.GetGoalString();
                    goals.AddGoal(S1);//Add to _goals list
                }
                
                else if (goalMenuSelection == 2)
                {
                    Console.WriteLine("Eternal Goal Selected");
                    EternalGoal E1 = new EternalGoal("", "", "", 0, false);
                    E1.GetGoalString();
                    goals.AddGoal(E1);//Add to _goals list
                }

                else if (goalMenuSelection == 3)
                {
                    Console.WriteLine("Checklist Goal Selected");
                    ChecklistGoal C1 = new ChecklistGoal("","","",0,0,0,0,false);
                    C1.GetGoalString();//Run Checklist and return data
                    goals.AddGoal(C1);//Add to _goals list
                }

                else if (goalMenuSelection == 4)
                {
                    generateMenu = true;
                }

                else
                {
                    Console.WriteLine("PLEASE ENTER A VALID NUMBER....");
                    Thread.Sleep(3000);
                }
            }
            

            else if (mainMenuSelection == 2)
            {
                goals.ListGoals();
                
            }

            else if (mainMenuSelection == 3)
            {
                goals.SaveGoals();
            }

            else if (mainMenuSelection == 4)
            {
                goals.LoadGoals();
            }

            else if (mainMenuSelection == 5)
            {
                goals.ListGoals();
                goals.RecordEvent();
            }

            else if (mainMenuSelection == 6)
            {
                generateMenu = false;
                Console.WriteLine("See you soon! Keep up the good work, and have a good day!!");
            }

            else
                {
                    Console.WriteLine("PLEASE ENTER A VALID NUMBER....");
                    Thread.Sleep(3000);
                }
        }
            
    }
        
}
