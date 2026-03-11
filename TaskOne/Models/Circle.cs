namespace TaskOne.Models;

public class Circle(double xAxis, double yAxis, double radius) : Shape(xAxis, yAxis)
{
    private double _radius = radius;
    
    public override void Scale(double factor)
    {
        _radius *= factor;
    }
}