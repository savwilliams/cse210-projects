//Derived Class

public class Circle : Shape
{
    //Attributes
    private double _radius;
    
    //Getters

    //Setters

    //Constructors
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
        
    }

    //Methods
    public override double GetArea(){
        return Math.Round(Math.PI * _radius * _radius, 2);
    }
}
