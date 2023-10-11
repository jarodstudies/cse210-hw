using System.Drawing;
using System.Runtime.CompilerServices;

public abstract class Shape
{
    private string _color;

    public Shape (string color)
    {

        _color = color;

    }


    public void GetColor(string color)
    {
        _color = color;
    }

    public string SetColor()
    {
        return _color;
    }

    public abstract double GetArea();


}