namespace TaskOne.Models;

public class Square(double xAxis, double yAxis, double side) : Shape(xAxis, yAxis)
{
    private double _side = side;

    public override void Scale(double factor)
    {
        _side *= factor;
    }
}