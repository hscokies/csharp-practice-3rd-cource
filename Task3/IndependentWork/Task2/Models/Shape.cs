using Shared.Geometry.Primitives;

namespace Task3.IndependentWork.Task2.Models;

internal abstract class Shape(double x, double y, double z)
{
    public abstract double GetVolume();
}