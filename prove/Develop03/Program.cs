using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer.\nThis is the scripture available to memorize.");
        Scripture scripture = new Scripture();
        Console.Write("Press any key to continue.");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine(scripture.GetScripture());   
        scripture.DivideText(scripture.GetScriptureText());
        
        Console.Write("Press any key to end the program.");
        Console.ReadKey();
    }

}