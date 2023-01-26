public class Journal{
    public string userOption = "";
    
    public void DisplayMenu(){

        Console.WriteLine("Welcome to your Journal app!");
        Console.WriteLine("Please choose one of the available options: ");
        Console.WriteLine("1-   Write\n2-   Display the Journal\n3-   Load\n4-   Save\n5-   Quit");

        Console.Write("What would you like to do?: ");
        userOption = Console.ReadLine();    
        
        optionSelected(userOption); 
    }
    private void optionSelected(string userOption){

        //START - main idea taken from: https://www.tutorialsteacher.com/articles/convert-string-to-int 
        
        /*Explanation about line 24-37 -->
        Each input given in the option menu will be evaluated. If it's a number between 1-5, will display the corresponding action.
        Otherwise, it will repeat the message "Please insert an option from 1 to 5." Until the user give the correct input.
        */

        bool isParsable = false;
        int number;

        while (isParsable == false)
        {
            isParsable = Int32.TryParse(userOption, out number);

            if (isParsable == false || number >= 6 || number <= 0)
            {
                    Console.WriteLine("Please insert an option from 1 to 5.");
                    userOption = Console.ReadLine();  
            }

        }
        // END idea


        if(userOption == "1")       //Write
        {
            Console.Clear();
            Console.WriteLine("You choose Option 1- Write an entry.");
            PromptGenerator _questions = new PromptGenerator();
            _questions.DisplayQuestion();

            Console.WriteLine("Your entry still not saved in any document.\nPress any key to continue.");
            Console.ReadLine();

        }
        else if(userOption == "2")  //Display
        {
            
            Console.WriteLine("Display option in progress.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        else if(userOption == "3")  //Load
        {
            Console.WriteLine("Load option in progress.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

        }
        else if(userOption == "4")  //Save
        {
            Console.WriteLine("Save option in progress.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        else if(userOption == "5")  //Quit
        {
            Console.WriteLine("Quit option in progress.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        // else                        //Incorrent input
        // {
        //     Console.WriteLine("Incorrect option. Please select between 1 to 5.");
        //     Console.WriteLine("Press any key to continue.");
        //     Console.ReadLine();
        // }
    }
}
//     private int ParseString(string userText){
//         bool isParsable = false;
//         int number;

//         while (isParsable == false)
//         {
//             isParsable = Int32.TryParse(userText, out number);
//             if (isParsable == false)
//             {
//                     Console.WriteLine("Please insert an option from 1 to 5.");
//             }
//             else
//             {
//                 isParsable = true;
//                 return number;
//             }
//         }
        
//     }

// }