using System;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    
    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }


    //OR...
    public string GetBookSection()
    {
        return _textbookSection;
    }

    public void SetBookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }


    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
    
}