using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayProgram();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayProgram()
    {
        DisplayWelcome();
        string name = PromptUserName();

        int number = PromptUserNumber();
        
        int squareNum = SquareNumber(number);
        Console.WriteLine($"{name}, the square of your number is {squareNum}.");
    }
    
}