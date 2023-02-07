using System;


class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.inCountryOrRemote();
            employee.EmployeeExperience();
            
        }

    public class Employee
    {   
    List<string> _name = new List<string>
    {
        "Rodrigo","John", "Mark", "Paul"
    };

    List<string> _address = new List<string>
    {
        "Argentina","USA", "Spain", "USA"
    };

    List<int> _yearsOfExperience = new List<int>
    {
        1, 5, 2, 15
    };

    public void EmployeeExperience()
    {
        
        for (int i=0; i<(_yearsOfExperience.Count());i++)
        {
            if (_yearsOfExperience[i] >= 0 && _yearsOfExperience[i] < 2 )
            {
                Console.WriteLine($"{_name[i]} is a Jr.");
            }
            else if (_yearsOfExperience[i] >= 2 && _yearsOfExperience[i] <5) 
            {
                Console.WriteLine($"{_name[i]} is a SSr.");    
            }
            else
            {
                Console.WriteLine($"{_name[i]} is a Sr.");    
            }
        }
    }
        
    public void inCountryOrRemote()
    {
        for (int i=0; i<(_address.Count());i++)
        {
            if(_address[i] != "USA"){
                Console.WriteLine($"{_name[i]} works remotely");
            }
            else{
                Console.WriteLine($"{_name[i]} works inside the country");
            }
        }
    
    }

    }
}


