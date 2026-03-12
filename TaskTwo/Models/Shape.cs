using TaskTwo.Utils;

namespace TaskTwo.models;

public abstract class Shape
{
    protected abstract double Area { get; }
    protected abstract Point[] Polygon { get; }

    public override string ToString()
    {
        return $"Area: {Area}\nPoints: {string.Join(',', Polygon)}";
    }

    public void Move(double deltaX, double deltaY)
    {
        for (var i = 0; i < Polygon.Length; i++)
        {
            var x = Polygon[i].X + deltaX;
            var y = Polygon[i].Y + deltaY;

            Polygon[i] = new Point(x, y);
        }
    }

    public int Compare(Shape other)
    {
        return Area.CompareTo(other.Area);
    }

    /// <summary>
    /// Производит проверку пересечения произвольных многоугольников в 2D пространстве.
    /// <remarks>
    /// Проверяет пересечение ребер и вложенность многоугольников.
    /// </remarks>
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Intersects(Shape other)
    {
        var otherPolygon = other.Polygon;
        
        for (var i = 0; i < Polygon.Length; i++)
        {
            var nextA = (i+1) % Polygon.Length;
            var edgeA = new Edge(Polygon[i], Polygon[nextA]);
            
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
        
        return Includes(otherPolygon[0]) || other.Includes(Polygon[0]);
    }

    /// <summary>
    /// Проверяет находиться ли указанная точка внутри текущего полигона используя алгоритм Ray casting.
    /// </summary>
    public bool Includes(Point point)
    {
        var pointsCount = Polygon.Length;
        var extreme = new Point(double.MaxValue, point.Y);

        var count = 0;
        for (var i = 0; i < pointsCount; i++)
        {
            var next = (i + 1) % pointsCount;

            var polygonSegment = new Edge(Polygon[i], Polygon[next]);
            var ray = new Edge(point, extreme);


            if (!polygonSegment.Intersects(ray) || polygonSegment.IsHorizontalIntersection(ray))
            {
                continue;
            }

            var onSegment = Geometry.Orientation(Polygon[i], point, Polygon[next]) == 0 &&
                            Geometry.OnSegment(Polygon[i], Polygon[next], point);
            
            
            if (onSegment)
            {
                return true;
            }
            
            count++;
        }

        return count % 2 != 0;
    }

    public bool Includes(Shape other)
    {
        return other.Polygon.All(Includes);
    }
}