public class Fraction
{
    //attributes
    private int _topNumber;
    private int _bottomNumber;

    //constructors
    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    //getters
    public int GetTopNumber()
    {
        return _topNumber;
    }

    public int GetBottomNumber()
    {
        return _bottomNumber;
    }

    //setters
    public void SetTopNumber(int top)
    {
        _topNumber = top;
    }

    public void SetBottomNumber(int bottom)
    {
        _bottomNumber = bottom;
    }

    //methods
    public string GetFractionString()
    {
        string fractionString = $"{_topNumber}/{_bottomNumber}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_topNumber / (double)_bottomNumber;
        return decimalValue;
    }
}