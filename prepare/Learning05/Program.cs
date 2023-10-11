using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");

        Square newSquare = new Square(5, "Blue");
        double area = newSquare.GetArea();

        Console.WriteLine(area);

        Rectangle newRectangle = new Rectangle(5,7,"Red");
        double recArea = newRectangle.GetArea();

        Console.WriteLine(recArea);

        Circle newCircle = new Circle(6,"Orange");
        double circArea = newCircle.GetArea();

        Console.WriteLine(circArea);
    }
}