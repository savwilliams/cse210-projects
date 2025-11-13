//Base Class

public class Shape
{
    //Attributes
    private string _color;

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
            return 0;
        }
        //This can also be written as abstract:
        //public abstract double GetArea();
}
