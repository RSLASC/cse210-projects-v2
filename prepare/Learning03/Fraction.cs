public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    // Constructors
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _bottom = bottom;
        _top = top;
    }
    
    // Getters and Setters
    public int GetTopNumber()
    {
        return _top;
    }
    
    public void SetTopNumber(int top)
    {
        _top = top;
    }

    public int GetBottomNumber()
    {
        return _bottom;
    }
    
    public void SetBottomNumber(int bottom)
    {
        _bottom = bottom;
    }

    // Methods for representations
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }

}