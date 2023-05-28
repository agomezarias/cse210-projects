using System;
using System.Collections.Generic;

public class Scripture
{
    private string _reference;
    private string _text;
    private List<Word> _words = new List<Word>();

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;

        string [] individualWords = text.Split(" ");
        
        foreach (string _singleWord in individualWords)
        {
            Word word = new Word(_singleWord);
            _words.Add(word);
            // Console.WriteLine(_singleWord); //TESTING
        }         
    }

    public void HideRandomWord()
    {
        //Sourced Help: https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-7.0
        //Sourced Help2: https://stackoverflow.com/questions/2019417/how-to-access-random-item-in-list#2019432

        Random random = new Random();
        List<Word> _shownWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                _shownWords.Add(word);
            }

        if (_shownWords.Count > 0)
            {
                int randomIndex = random.Next(_shownWords.Count);
                _shownWords[randomIndex].Hide();

            }
        } 
    }


    public bool IsAllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            
                return word.IsHidden();
                 
        }
        
        return true;
    }


    public void GetText()  //Reference and verse(s) rendered.
    {
        Console.Clear(); //Clears console of everything except the scripture.
        Console.Write($"{_reference} - ");

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                Console.Write(" _ ");
            }
            else
            {
                Console.Write(word.GetWordText() + " ");
            }
        }
        
        Console.WriteLine();
    }
}