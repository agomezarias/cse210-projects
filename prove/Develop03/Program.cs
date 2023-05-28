using System;

class Program
{
    static void Main(string[] args)
    {
        bool exitMemorizer = false;

        ScriptureReference reference = new ScriptureReference("John", 3, 16);
        string _reference = reference.ToTextString();
        // Console.WriteLine(reference.ToString()); //TESTING

        Word text = new Word("For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life.");
        string _text = text.GetWordText();


        // Reference and text (Complete scripture and verse)
        Scripture scripture = new Scripture(_reference, _text);
        // Console.WriteLine(scripture.GetText());  //TESTING
        
        
        while (!exitMemorizer)
        {
            if (!scripture.IsAllWordsHidden()) //Continue unless all words are gone.
            {

                scripture.GetText(); //Display the scripture reference and verse.

                Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
                string userInput = Console.ReadLine();

                if (userInput == "quit")
                {
                    exitMemorizer = true;
                    Console.WriteLine("!!Hopefully this helped with your memorization!!");
                    break;
                }
                

                else
                {
                    scripture.HideRandomWord();

                    if(scripture.IsAllWordsHidden())
                    {
                        exitMemorizer = true;
                    }
                }
            }
            
        }
        return;
    }        
}