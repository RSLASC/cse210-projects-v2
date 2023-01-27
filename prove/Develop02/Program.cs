using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
            Journal _startProgram = new Journal();

            while (_startProgram._userOption != "5")
            {
                Console.Clear();
                _startProgram.DisplayMenu();
            }

            
        }

}