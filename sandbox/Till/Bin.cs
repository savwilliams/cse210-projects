class Bin
{
    //attributes
    private string _denomination;
    private double _value; //decimal can be used in place of double for financial data
    private int _count;


    //behaviors
    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }

    // modifier method "Alter" method
    public void Alter(int delta)
    {
        _count += delta;

    }

    //accesor "getter" method
    public string GetDenominator()
    {
        return _denomination;
    }

    public int GetCount() { return _count; }

}