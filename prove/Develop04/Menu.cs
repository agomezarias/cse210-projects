using System;

public class Menu
{
    private bool generateMenu;
    private int _menuSelection;


    public Menu(int menuSelection)
    {
        generateMenu = true;
        _menuSelection = menuSelection;

    }
    
    //Menu Options
    public static int MainMenu()
        {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Start Breathing Activity");
        Console.WriteLine("   2. Start Reflection Activity");
        Console.WriteLine("   3. Start Listing Activity");
        Console.WriteLine("   4. Quit");
        
        Console.WriteLine("Select a choice from the menu: ");
        string menuInput = Console.ReadLine(); // User input / selection.
        int menuSelection = int.Parse(menuInput);


        return menuSelection;
        }
    
}