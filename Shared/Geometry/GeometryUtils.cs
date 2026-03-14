using Shared.Geometry.Primitives;

namespace Shared.Geometry;

public static class GeometryUtils
{
    /// <summary>
    /// Вычисляет ориентацию тройки точек.
    /// </summary>
    /// <param name="p"></param>
    /// <param name="q"></param>
    /// <param name="r"></param>
    /// <returns>
    /// <b>Если результат больше 0</b>: Вектор от p к q делает поворот против часовой стрелки на точку r <br/>
    /// <b>Если результат меньше 0</b>: Вектор от p к q делает поворот по часовой стрелке на точку r <br/>
    /// <b>Если результат равен 0</b>: Все три точки лежат на одной прямой
    /// </returns>
    public static double Orientation(Point p, Point q, Point r)
    {
        return (q.X - p.X) * (r.Y - p.Y) - (q.Y - p.Y) * (r.X - p.X);
    }
    
    /// <summary>
    /// Проверяет находиться ли точка r на отрезке p-q
    /// </summary>
    /// <returns>
    /// true, если отрезок p-q включает точку r и false иначе
    /// </returns>
    public static bool OnSegment(Point p, Point q, Point r)
    {
        return r.X <= Math.Max(p.X, q.X) && r.X >= Math.Min(p.X, q.X) &&
               r.Y <= Math.Max(p.Y, q.Y) && r.Y >= Math.Min(p.Y, q.Y);
    }

    public static ICollection<Point> SortClockwise(this ICollection<Point> points)
    {
        var centerX = points.Average(p => p.X);
        var centerY = points.Average(p => p.Y);
        return points.OrderBy(p =>
        {
            var angle = Math.Atan2(p.Y - centerY, p.X - centerX);
            return -angle;
        }).ToArray();
    }
}