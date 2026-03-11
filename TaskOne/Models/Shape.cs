namespace TaskOne.Models;

public abstract class Shape(double xAxis, double yAxis)
{
    private double _angleDeg = 0;
    private double XAxis { get; set; } = xAxis;
    private double YAxis { get; set; } = yAxis;

    public abstract void Scale(double factor);

    public void Move(double dx, double dy)
    {
        XAxis += dx;
        YAxis += dy;
    }
    
    public void Rotate(double angleDeg)
    {
        const double maxAngle = 360;
        _angleDeg = (_angleDeg + angleDeg) % maxAngle;
    }
}