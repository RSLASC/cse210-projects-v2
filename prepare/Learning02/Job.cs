public class Job
{
    // The C# convention is to start member variables with an underscore _
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // A method that displays the person's full name as used in eastern 
    // countries or <family name, given name>.
    public void Display()
    {
    
    Console.WriteLine($"{_jobTitle} {_company} {_startYear}-{_endYear}");
    
    }

    // A method that displays the person's full name as used in western 
    // countries or <given name family name>.
        
}