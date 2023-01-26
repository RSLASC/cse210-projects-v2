using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
            Journal startProgram = new Journal();

            while (startProgram.userOption != "5")
            {
                Console.Clear();
                startProgram.DisplayMenu();
                
            }

            
        }
}