namespace Task3.IndependentWork.Task2.Models;

internal sealed class Ellipsoid(double a, double b, double c, double x, double y, double z) : Shape(x,y,z)
{
    public override double GetVolume()
    {
        return (4 * Math.PI * a * b * c) / 3;
    }
}