

public class Rectangle : Shape
{

    private double _length;
    private double _width;

    public Rectangle (double lenght, double width, string color) : base (color)
    {
        _width = width;
        _length = lenght;
    }

    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }


}