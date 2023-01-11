/*Core Requirements
Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the appropriate letter grade. 
(At this point, you'll have a separate print statement for each grade letter in the appropriate block.)

Assume that you must have at least a 70 to pass the class. 
After determining the letter grade and printing it out. 
Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. 
If not, display a different message to encourage them for next time.

Change your code from the first part, so that instead of printing the letter grade 
in the body of each if, elif, or else block, instead create a new variable called letter and then in each block, 
set this variable to the appropriate value. Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.
*/
/*Stretch Challenge
Add to your code the ability to include a "+" or "-" next to the letter grade, such as B+ or A-. For each grade, you'll know it is a "+" if the last digit is >= 7.
You'll know it is a minus if the last digit is < 3 and otherwise it has no sign.

After your logic to determine the grade letter, add another section to determine the sign. 
Save this sign into a variable. Then, display both the grade letter and the sign in one print statement.
Hint: To get the last digit, you could divide the number by 10, and get the remainder. You might refer back to the preparation material for Lesson 03 to see the operators and find the one that does division and gives you the remainder.

At this point, don't worry about the exceptional cases of A+, F+, or F-.

Recognize that there is no A+ grade, only A and A-. Add some additional logic to your program to detect this case and handle it correctly.

Similarly, recognize that there is no F+ or F- grades, only F. Add additional logic to your program to detect these cases and handle them correctly.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // User input
        Console.Write("Please, inform your grade percentage: ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);
        
        // Initialize variables wiith empty values
        string letter = "";
        string sign = "";

        // Evaluates the grade taken from the user, and sets the letter grade
        if (grade <= 100 && grade >= 90)        // A
        {   
            letter = "A";
        }
        else if (grade < 90)     // B
        {
            letter = "B";
        }
        else if (grade < 80)     // C
        {
            letter = "C";
        }
        else if (grade < 70)     // D
        {
            letter = "D";
        }
        else if (grade < 60 && grade >= 0)      // F
        {
            letter = "F";
        }
        else                                    // Wrong numbers 
        {
            Console.WriteLine("The informed grade percentage is not valid.");
        }

        // Evaluates if the letter grade it's an F. Otherwise, continues with the calculation for the other grades
        if (letter != "F")
        {
            int reminderFromGrade = grade % 10;
            // int reminder = Math.DivRem(grade,10, out reminder);
            // Above Method taken from https://www.geeksforgeeks.org/c-sharp-math-divrem-method/

            if (reminderFromGrade >= 7 && letter != "A")     // "+" sign for all the grades, excepting for A, and F at line 62
            {
                sign = "+";

            }
            else if (reminderFromGrade < 3)                 // "-" sign
            {
                sign = "-";
            }
            else                                            // no sign
            {
                sign = "";
            }

        }
        
        letter = letter + sign;

        // If the letter variable is empty, it will not display anything else.
        if (letter != string.Empty)
        {
            
            Console.WriteLine($"Your grade is {letter}.");
            
            // If the valid input is between 70 and 100, it will display a congratulations message. Otherwise, it will return a encouraging message.
            if (grade >= 70 && grade <100)
            {
                Console.WriteLine("You passed the class. Wohoo!");
            }
            else if (grade > 0 && grade < 70)
            {
                Console.WriteLine("Oh, no. It was not enough to pass the class. Keep trying, and good luck next semester!");
            }

        }

    }

}