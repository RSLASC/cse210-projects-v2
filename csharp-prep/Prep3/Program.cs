using System;

class Program
{
    static void Main(string[] args)
    {
        {/*Core requirement # 1
        Console.Write("What is the magic number?: ");
        string hiddenNumber = Console.ReadLine();
        int magicNumber = int.Parse(hiddenNumber);
        
        Console.Write("What is your guess?: ");
        string chooseNumber = Console.ReadLine();
        int userNumber = int.Parse(chooseNumber);

        if (magicNumber == userNumber)
        {
            Console.WriteLine("YAY! you found the magic number!");
        }
        else if (userNumber > magicNumber)
        {
            Console.Write("Lower");
        }
        else
        {
            Console.Write("Higher");
        */
        }

        {/*Core requirement #2
        
        int userNumber = 0;

        Console.Write("What is the magic number?: ");
        string hiddenNumber = Console.ReadLine();
        int magicNumber = int.Parse(hiddenNumber);
        
        while (magicNumber != userNumber)
        {
            Console.Write("What is your guess?: ");
            string chooseNumber = Console.ReadLine();
            userNumber = int.Parse(chooseNumber);

            if (magicNumber == userNumber)
            {
                Console.WriteLine("YAY! you found the magic number!");
            }
            else if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
        */}
    
        
        /*Core requirement #3*/

        int userNumber = -1;
        int guesses = 1;

        Random rnd = new Random();

        int hiddenNumber = (rnd.Next(1, 100)); // returns random integers between 1 and 100
        
        string continueGame = "yes";
        while (continueGame == "yes")
        {
            
            while (hiddenNumber != userNumber)
            {
                Console.Write("What is your guess?: ");
                string chooseNumber = Console.ReadLine();
                userNumber = int.Parse(chooseNumber);

                if (hiddenNumber == userNumber && guesses == 1)
                {
                    Console.WriteLine("YAY! you found the magic number in your first try!");
                }
                else if (hiddenNumber == userNumber && guesses != 1)
                {
                    Console.WriteLine($"YAY! you found the magic number in your try #{guesses}!");
                }
                else if (userNumber > hiddenNumber)
                {
                    Console.WriteLine("Lower");
                    guesses += 1;
                }
                else
                {
                    Console.WriteLine("Higher");
                    guesses += 1;
                }
                
            }

            Console.Write("Would you like to continue? (yes/no): ");
            string userInput = Console.ReadLine();
            if (userInput != continueGame)
            {
                continueGame = "no";
                Console.WriteLine("Thanks for playing.");
            }
            else
            {
                rnd = new Random();
                hiddenNumber = (rnd.Next(1, 100));
                guesses = 1;
            }

        }
    }
}