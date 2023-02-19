public class Word
{
    private string[] _words;
    char[] _separator = {' '};

    public void SetListOfWords(string scriptureText)
    {
        _words = scriptureText.Split(_separator);
        
        foreach(string word in _words)
        {
            
            foreach(char character in word)
            {
                if (character == ';')
                {
                    Console.Write(";");
                }
                else if (character == ',')
                {
                    Console.Write(",");
                }
                else if (character == '.')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("_");
                }
            }
            
            Console.Write(" ");

        }
        Console.WriteLine();
    
    }
    

}