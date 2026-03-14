using Shared;
using Shared.Geometry.Primitives;

namespace Task2.IndependentWork.Shapes.Models;

internal sealed class Pentagon : Polygon
{
    private Pentagon(Point[] points) : base(points)
    {
    }


    public static Pentagon CreateRegular(double radius, Point center)
    {
        const int points = 5;

        var polygon = new Point[points];
        for (var i = 0; i < points; i++)
        {
            var angle = 2 * Math.PI * i / points;

            var x = center.X + radius * Math.Cos(angle);
            var y = center.Y + radius * Math.Sin(angle);
            polygon[i] = new Point(x, y);
        }

        return new Pentagon(polygon);
    }
}