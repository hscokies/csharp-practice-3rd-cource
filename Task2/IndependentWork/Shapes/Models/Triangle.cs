using Shared.Geometry.Primitives;

namespace Task2.IndependentWork.Shapes.Models;

internal sealed class Triangle(Point a, Point b, Point c) : Polygon([a,b,c]);