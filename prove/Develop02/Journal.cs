public class Journal{
    public string userOption = "";
    public int number;
    public void DisplayMenu(){

        Console.WriteLine("Welcome to your Journal app!");
        Console.WriteLine("Please choose one of the available options: ");
        Console.WriteLine("1-   Write\n2-   Display the Journal\n3-   Load\n4-   Save\n5-   Quit");

        Console.Write("What would you like to do?:\n> ");
        userOption = Console.ReadLine();    
        
        optionSelected(userOption); 
    }
    private void optionSelected(string userOption){

        //START - main validation idea taken from: https://www.tutorialsteacher.com/articles/convert-string-to-int 
        
        /*Explanation about line 24-37 -->
        Each input given in the option menu will be evaluated. If it's a number between 1-5, will display the corresponding action.
        Otherwise, it will repeat the message "Please insert an option from 1 to 5." Until the user give the correct input.
        This way, we ensure that no other input than 1-5 is accepted, meaning that 
        */

        bool isParsable = false;
        

        while (isParsable == false || (number <1 || number > 5))
        {
            isParsable = Int32.TryParse(userOption, out number);

            if (isParsable == false || (number > 5 || number < 1))
            {
                    Console.WriteLine("Please insert an option from 1 to 5. ");
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
            Console.ReadKey();

        }
        else if(userOption == "2")  //Display
        {
            Console.Clear();
            Console.WriteLine("You choose Option 2- Display entries.");
            
            Console.WriteLine("Display option in progress.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        else if(userOption == "3")  //Load
        {
            Console.Clear();
            Console.WriteLine("You choose Option 3- Load Journal.");

            Console.WriteLine("Load option in progress.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }
        else if(userOption == "4")  //Save
        {
            Console.Clear();
            Console.WriteLine("You choose Option 4- Save Journal.");

            Console.WriteLine("Save option in progress.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        else if(userOption == "5")  //Quit
        {
            Console.Clear();
            Console.WriteLine("You choose Option 5- Quit program.");

            Console.WriteLine("Thanks for using the Journal program!");
            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }
        else                        //Incorrent input
        {
            Console.WriteLine("Input not handled");
            Console.ReadKey();
        }
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