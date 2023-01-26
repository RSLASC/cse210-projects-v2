using System.Collections.Generic;
public class PromptGenerator{

    public void DisplayQuestion(){
        
        Entry newEntry = new Entry();

        List<String> _Questions = new List<String>();

        _Questions.Add("What was the best part of my day?");
        _Questions.Add("What was the strongest emotion I felt today?");
        _Questions.Add("Who was the most interesting person I interacted with today?");
        _Questions.Add("What thing do you feel that you could have done better?");
        _Questions.Add("Describe something about your day that you would like your descendants knows about");
        
        Random rnd = new Random();
        newEntry._Prompt = _Questions[rnd.Next(0, _Questions.Count)];   // Return a random question between 0-index and max-index.
 
        Console.WriteLine("Please insert an entry\n"); 

        DateTime theCurrentTime = DateTime.Now;
        newEntry._DateTime = theCurrentTime.ToShortDateString();

        Console.Write($"{newEntry._Prompt}\n{newEntry._DateTime} > ");
        newEntry._UserInput = Console.ReadLine();

        
    }
    
}