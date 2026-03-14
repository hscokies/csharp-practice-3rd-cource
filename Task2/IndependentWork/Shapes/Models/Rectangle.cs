using Shared.Geometry.Primitives;

namespace Task2.IndependentWork.Shapes.Models;

internal class Rectangle(Point start, double width, double height) : Polygon([
    start,
    start with { X = start.X + width },
    new Point(start.X + width, start.Y + height),
    start with { Y = start.Y + height },
]);