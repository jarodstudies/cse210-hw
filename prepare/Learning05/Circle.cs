

public class Circle : Shape
{

    private double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = _radius * _radius * Math.PI;
        return area;
    }



}