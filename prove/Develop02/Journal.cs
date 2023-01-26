public class Journal{
    public string userOption = "";
    
    public void DisplayMenu(){

        Console.WriteLine("Welcome to your Journal app!");
        Console.WriteLine("Please choose one of the available options: ");
        Console.WriteLine("1-   Write\n2-   Display\n3-   Load\n4-   Save\n5-   Quit");

        userOption = Console.ReadLine();    

        optionSelected(userOption);
    }
    private void optionSelected(string userOption){
        if (userOption == "1")//Write
        {
            Console.Clear();
            Console.WriteLine("You choose Option 1- Write an entry.");
            PromptGenerator _questions = new PromptGenerator();
            _questions.DisplayQuestion();

            Console.WriteLine("Your entry still not saved in any document.\nPress any key to continue.");
            Console.ReadLine();

        }
        else if(userOption == "2")//Display
        {
            
            Console.WriteLine("Display option in progress.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        else if(userOption == "3")//Load
        {
            Console.WriteLine("Load option in progress.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

        }
        else if(userOption == "4")//Save
        {
            Console.WriteLine("Save option in progress.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        else if(userOption == "5")//Quit
        {
            Console.WriteLine("Quit option in progress.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Incorrect option. Please select between 1 to 5.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
    }

}