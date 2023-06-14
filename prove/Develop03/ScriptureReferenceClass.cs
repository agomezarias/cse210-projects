using System;

public class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public ScriptureReference(string book, int chapter, int verseStart)
    //Allows only one verse in the scripture.
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseStart;

    }

    public ScriptureReference(string book, int chapter, int verseStart, int verseEnd)
    //Will allow for more than one verse in the scripture.
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;

    }

    public string ToTextString()  //Reference rendered
    {
        if (_verseStart == _verseEnd)
        {
            return $"{_book} {_chapter}:{_verseStart}";

        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd} ";

        }
    }
}
