public class Entry{
    public List <string> _DateTime;
    public List <string> _Prompt;
    public List <string> _UserInput;

    public void AddingPrompt(string input)
    {
        this._Prompt.Add(input);
    }

    public void Display()
    {

        foreach (var _innerEntry in _UserInput )
        {
            Console.WriteLine(_innerEntry);
        }
    }

}