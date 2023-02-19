public class Reference
{
    //Stores book's name
    private List<string> _book = new List<string>
    {
        "John","Proverbs"
    };
    //Stores chapter from the corresponding book
    private List<string> _chapter = new List<string>
    {
        "3:","3:"
    };
    //Stores verse info. from corresponding book and chapter.
    private List<string> _verseInfo = new List<string>
    {
        "16","5-6"
    };

    private string GetFullReference(int refNumber)
    {
        return _book[refNumber] + _chapter[refNumber] + _verseInfo[refNumber];
    }

    public void displayReference()
    {
        Console.WriteLine($"{_book} {_chapter}{_verseInfo}");        
    }

    public void displayReferencesAvailable()
    {        
        for (int i = 0; i < _book.Count; i++)
        {
            Console.WriteLine($"{i+1} - {_book[i]} {_chapter[i]}{_verseInfo[i]}");        
        }
    }

}