using System.Diagnostics;
using Task3.IndependentWork.Task2.Models;

namespace Task3.IndependentWork.Task2;

internal static class Sandbox
{
    public static void Main()
    {
        const double expected = 125.66;
        
        var ellipsoid = new Ellipsoid(5, 3, 2, 0,0,0);
        var actual = Math.Round(ellipsoid.GetVolume(), 2);
        
        Debug.Assert(actual is expected);
    }
}