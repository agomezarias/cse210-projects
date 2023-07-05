using System;

public class Menus
{
    private int _mainMenuSelection;
    private int _goalMenuSelection;


    public Menus(int mainMenuSelection, int goalMenuSelection)
    {
        _mainMenuSelection = mainMenuSelection;
        _goalMenuSelection = goalMenuSelection;
    }
    
    //Main Menu Options
    public static int MainMenu()
        {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");

        
        Console.Write("Select a choice from the menu: ");
        string menuInput = Console.ReadLine(); // User input / selection.
        int mainMenuSelection = int.Parse(menuInput);


        return mainMenuSelection;
        }

    //Goal Menu Options
    public static int GoalMenu()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("   1. Simple Goal ");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.WriteLine("   4. Main Menu");


        Console.Write("Which type of goal would you like to create? ");
        string menuInput = Console.ReadLine(); // User input / selection.
        int goalMenuSelection = int.Parse(menuInput);
        

        return goalMenuSelection;
    }
    
}