using Shared.Geometry;
using Shared.Geometry.Primitives;

namespace Task2.IndependentWork.Shapes.Models;

internal class Polygon(params Point[] points) : Shape
{
    private double? _area;
    protected Point[] Points { get; init; } = points;

    public override double Area()
    {
        if (_area.HasValue)
        {
            return _area.Value;
        }
        
        // Для вычисления площади точки полигона должны быть отсортированы
        // https://www.mathopenref.com/coordpolygonarea.html
        var sortedPoints = Points.SortClockwise().ToArray();

        var sum = 0d;
        for (var i = 0; i < sortedPoints.Length; i++)
        {
            var point = sortedPoints[i];
            var next = sortedPoints[(i + 1) % sortedPoints.Length];
        
            sum += (point.X * next.Y - point.Y * next.X);
        }
    
        _area = Math.Abs(sum / 2);
        
        return _area.Value;
    }



    public void Move(double deltaX, double deltaY)
    {
        for (var i = 0; i < Points.Length; i++)
        {
            var x = Points[i].X + deltaX;
            var y = Points[i].Y + deltaY;

            Points[i] = new Point(x, y);
        }
    }

    /// <summary>
    /// Производит проверку пересечения произвольных многоугольников в 2D пространстве.
    /// <remarks>
    /// Проверяет пересечение ребер и вложенность многоугольников.
    /// </remarks>
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Intersects(Polygon other)
    {
        var otherPolygon = other.Points;
        
        for (var i = 0; i < Points.Length; i++)
        {
            var nextA = (i+1) % Points.Length;
            var edgeA = new Edge(Points[i], Points[nextA]);
            
            for (var j = 0; j < otherPolygon.Length; j++)
            {
                var nextB = (j + 1) % otherPolygon.Length;
                var edgeB = new Edge(otherPolygon[j], otherPolygon[nextB]);

                if (edgeA.Intersects(edgeB))
                {
                    return true;
                }
            }
        }
        
        return Includes(otherPolygon[0]) || other.Includes(Points[0]);
    }

    /// <summary>
    /// Проверяет находиться ли указанная точка внутри текущего полигона используя алгоритм Ray casting.
    /// </summary>
    public bool Includes(Point point)
    {
        var pointsCount = Points.Length;
        var extreme = new Point(double.MaxValue, point.Y);

        var count = 0;
        for (var i = 0; i < pointsCount; i++)
        {
            var next = (i + 1) % pointsCount;

            var polygonSegment = new Edge(Points[i], Points[next]);
            var ray = new Edge(point, extreme);


            if (!polygonSegment.Intersects(ray) || polygonSegment.IsHorizontalIntersection(ray))
            {
                continue;
            }

            var onSegment = GeometryUtils.Orientation(Points[i], point, Points[next]) == 0 &&
                            GeometryUtils.OnSegment(Points[i], Points[next], point);
            
            
            if (onSegment)
            {
                return true;
            }
            
            count++;
        }

        return count % 2 != 0;
    }

    public bool Includes(Polygon other)
    {
        return other.Points.All(Includes);
    }

    public override string ToString()
    {
        return base.ToString() + $"\n{nameof(Polygon)}:\n\t{nameof(Points)}:{string.Join(',', Points)}";
    }
}