namespace TaskTwo.models;

public class Pyramid(double a, double b, double angleAb, double height)
    : TaskOne.Models.Triangle(a, b, angleAb)
{
    private double _height = height;
    private double? _volume;

    public Pyramid(Pyramid other) : this(other.GetA(), other.GetB(), other.GetAngleAb(), other.GetHeight())
    {
    }
    
    public double GetHeight() => _height;
    public double SetHeight(double height) => _height = height;

    public double Volume()
    {
        if (_volume.HasValue)
        {
            return _volume.Value;
        }

        _volume = (1.0 / 3.0) * Area() * _height;
        return _volume.Value;
    }
    
    public static double operator +(Pyramid left, Pyramid right)
    {
        return left.Volume() + right.Volume();
    }

    public override string ToString()
    {
        return base.ToString() + $"\tHeight:{_height}\tVolume:{Volume()}";
    }
}