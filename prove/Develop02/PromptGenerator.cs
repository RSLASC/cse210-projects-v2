using System.Collections.Generic;
public class PromptGenerator{

    List<string> _questions = new List<string>
    {
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "Who was the most interesting person I interacted with today?",
        "What thing do you feel that you could have done better?",
        "Describe something about your day that you would like your descendants knows about"
    };

    public void DisplayQuestion()
    {

        Entry _NewEntry = new Entry();

        /* BLOCK: List defined inside the function. Need to verify pros and cons
        // List<String> _Questions = new List<String>();

        // _Questions.Add("What was the best part of my day?");
        // _Questions.Add("What was the strongest emotion I felt today?");
        // _Questions.Add("Who was the most interesting person I interacted with today?");
        // _Questions.Add("What thing do you feel that you could have done better?");
        // _Questions.Add("Describe something about your day that you would like your descendants knows about");
        */
        
        Console.WriteLine("Please insert an entry based on the next prompt, or feel free to write your thought\n"); 
        
        Random rnd = new Random();
        string tempPrompt = _questions[rnd.Next(0, _questions.Count)];
        _NewEntry._prompt.Add(tempPrompt);                                  // Return a random question between 0-index and max-index. -list of string
        // _NewEntry._prompt = _Questions[rnd.Next(0, _Questions.Count)];   // Return a random question between 0-index and max-index. -string
 

        DateTime theCurrentTime = DateTime.Now;
        string tempDateTime = theCurrentTime.ToShortDateString();
        _NewEntry._dateText.Add(tempDateTime);                              //list of string
        // _NewEntry._dateText = theCurrentTime.ToShortDateString();        //string

        
        Console.Write($"{_NewEntry._prompt.Last()}\n{_NewEntry._dateText.Last()} > ");
        _NewEntry._userEntry.Add(Console.ReadLine());                       //list of string
        // _NewEntry._userEntry = Console.ReadLine();                       //string

        
        
    }
    
}