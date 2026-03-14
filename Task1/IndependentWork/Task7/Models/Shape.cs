using Shared.Geometry.Primitives;

namespace Task1.IndependentWork.Task7.Models;

internal abstract class Shape(Point center, double angle)
{
    private Point _center = center;
    private double _angle = angle;
    
    public abstract void Resize(double scale);

    public void Move(Point delta)
    {
        _center = new Point(X: _center.X + delta.X, Y: _center.Y + delta.Y);
    }

    public void Rotate(double angle)
    {
        _angle = (_angle + angle) % 180;
    }
    
    public override string ToString()
    {
        return $"{nameof(Shape)}:\n\tCenter:{_center}\n\tAngle:{_angle}";
    }
}