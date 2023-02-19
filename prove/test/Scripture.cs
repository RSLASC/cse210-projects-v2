public class Scripture
{   
    private Reference _scriptRef = new Reference();
    
    private string _scriptureText = 
    
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have heverlasting life.";
    

    public List<string> GetScriptureTextList(int refNumber)
    {
        return _scriptureText[refNumber];
    }

    public void GetReferencesAvailable()
    {        
        _scriptRef.displayReferencesAvailable();
    }

}