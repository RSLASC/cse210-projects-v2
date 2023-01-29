public class LoadFrom{
    
    public string _enterFileName = "";

    public void LoadFileFrom(ref string  _enterFileName)
    {   
        
        Console.Write("Please insert the filename you would like to load, including the extension (i.e: myTextFile.txt) > ");
        _enterFileName = Console.ReadLine();

    } 
    
}