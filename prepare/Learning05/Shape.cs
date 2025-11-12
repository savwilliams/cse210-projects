//Base Class

public class Shape
{
    //Attributes
    private string _color;
    private double _area;

    //Getters
    public string GetColor()
        {
            return _color;
        }

    //Setters
    public void SetColor(string color)
        {
            _color = color;
        }

    //Constructors
    public Shape(string color)
    {
        _color = color;
    }


    //Methods
    public virtual double GetArea()
        {
            return _area;
        }

}
