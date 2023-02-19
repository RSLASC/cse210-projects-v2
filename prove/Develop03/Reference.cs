public class Reference
{    
    private string _book;    
    private string _chapter;
    private string _verseInfo;
    public string GetReference()
    {
        return _book + " " + _chapter + ":" + _verseInfo + "\n";
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }
    public void SetVerse(string verse)
    {
        _verseInfo = verse;
    }
    public Reference()
    {
        _book = "Proverbs";
        _chapter = "3";
        _verseInfo = "5-6";
    }
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verseInfo = verse;
    }
    
    // Getters
    // public string GetBook()
    // {
    //     return _book;
    // }
    // public int GetChapter()
    // {
    //     return _chapter;
    // }
    // public int GetVerse()
    // {
    //     return _verseInfo;
    // }


}