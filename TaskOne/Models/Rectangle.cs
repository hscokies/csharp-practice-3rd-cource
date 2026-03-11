namespace TaskOne.Models;

public class Rectangle(double xAxis, double yAxis, double width, double height) : Shape(xAxis, yAxis)
{
    private double _width = width;
    private double _height = height;

    public override void Scale(double factor)
    {
        _width *= factor;
        _height *= factor;
    }
}