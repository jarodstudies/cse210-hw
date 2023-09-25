using System;


public class Fraction
{

    private int _top ;
    private int _bottom ;

    public Fraction()
    {

        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {

        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int bottom, int top)
    {
        _bottom = bottom;
        _top = top;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        double valueDecimal = (double)_top/(double)_bottom;
        return valueDecimal;
    }



}