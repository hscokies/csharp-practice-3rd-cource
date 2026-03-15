namespace Shared.Geometry.MainTask;

public class Pyramid : Triangle
{
    private double _height;
    private double? _volume;
    
    public double GetHeight() => _height;

    public void SetHeight(double height)
    {
        _height = height;
        _volume = null;
    }

    public Pyramid(double a, double b, double angleAb, double height)
    {
        SetA(a);
        SetB(b);
        SetAngleAb(angleAb);
        _height = height;
    }
    
    // Это имелось под оператором присваивания?
    public Pyramid(Pyramid other) : this(other.GetA(), other.GetB(), other.GetAngleAb(), other.GetHeight())
    {
    }
    
    
    public double Volume()
    {
        if (_volume.HasValue)
        {
            return _volume.Value;
        }

        _volume = Area() * _height / 3;
        return _volume.Value;
    }
    
    public static double operator +(Pyramid left, Pyramid right)
    {
        return left.Volume() + right.Volume();
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"{nameof(Pyramid)}:\n\tHeight:{_height}\n\tVolume:{Volume()}");
    }
}