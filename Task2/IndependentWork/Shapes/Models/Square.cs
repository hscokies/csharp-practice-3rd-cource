using Shared.Geometry.Primitives;

namespace Task2.IndependentWork.Shapes.Models;

internal sealed class Square(Point start, double side) : Rectangle(start, side, side);