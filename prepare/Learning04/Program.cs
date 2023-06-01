using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Alberto Gomez", "Geometry");
        //OR...
        // assign1.SetName("Alberto Gomez");
        // assign1.SetTopic("Geometry");
        Console.WriteLine(assign1.GetSummary());


        MathAssignment assign2 = new MathAssignment("Juan Pablo", "Multiplication", "7.3", "8-19");
        //OR...
        // MathAssignment assign2 = new MathAssignment();
        // assign2.SetName("Juan Pablo");
        // assign2.SetTopic("Multiplication");
        // assign2.SetBookSection("7.3");
        // assign2.SetProblems("8-19");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        WritingAssignment assign3 = new WritingAssignment("Joe Dirt", "Space Exploration", "Black Holes");
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());
    }
}