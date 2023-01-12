/*This activity will help you learn to work with LISTS and GENERICS in C#.*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<string> numberList = new List<string>();

        string userNumber;
        bool isNotZero = true;
        int number;
        float total = 0;
        int max = 0;
        int min = -1;
        float average;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (isNotZero)
        {
            Console.Write("Please insert a number: ");
            userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            

            if (number == 0)
            {
                isNotZero = false;
            }                
            else
            {
                numberList.Add(userNumber);
                total += number;
                if (number > max) 
                {
                    max = number;
                }
                else if(number<min)
                {
                    min = number;
                }
            }
        }

        Console.WriteLine($"The total is: {total}");
        
        if (total != 0)
        {
            average = total / numberList.Count;

            Console.WriteLine($"The average is: {average}");    
        }
        
        Console.WriteLine($"The maximum number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");

        
        
        /*//iterating by element
        foreach (string word in numberList) 
        {
            Console.WriteLine(word);
        }
        // iterating by index
        for (int i = 0; i < numberList.Count; i++)
        {
            Console.WriteLine(numberList[i]);
        }*/
    }
}