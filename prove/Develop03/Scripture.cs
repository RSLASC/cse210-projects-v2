public class Scripture
{
    Reference reference = new Reference();
    string _scriptureText;

    public Scripture()
    {
        Reference reference = new Reference();
        _scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
    }

    public string GetScriptureText()
    {
        return _scriptureText;
    }
    public void SetScriptureText(string text)
    {
        _scriptureText = text;
    }

    public string GetScripture()
    {
        // Console.WriteLine(reference.GetReference() + GetScriptureText());
        return (reference.GetReference() + GetScriptureText());
    }

    public void DivideText(string var)
    {
        Word word = new Word();
        word.SetListOfWords(var);
        
    }


}