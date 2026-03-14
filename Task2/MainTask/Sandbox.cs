using Shared.Geometry.MainTask;

namespace Task2.MainTask;

internal static class Sandbox
{
    public static void Main()
    {
        VolumeSum();
        Copy();
        PyramidArray();
    }

    private static void VolumeSum()
    {
        PrintHeader(nameof(VolumeSum));
        var left = new Pyramid(6, 8, 30, 10);
        var right = new Pyramid(5, 5, 60, 12);
        
        left.Show();
        Console.WriteLine();
        right.Show();
        
        Console.WriteLine($"\nSum of volumes: {left + right}");
    }

    private static void Copy()
    {
        PrintHeader(nameof(Copy));
        var pyramid = new Pyramid(7, 9, 45, 8);
        var copy = new Pyramid(pyramid);
        pyramid.Show();
        Console.WriteLine();
        copy.Show();
    }

    private static void PyramidArray()
    {
        PrintHeader(nameof(PyramidArray));
        Pyramid[] pyramids =
        [
            new(6, 8, 30, 10),
            new(5, 5, 60, 12),
            new(7, 9, 45, 8),
        ];

        foreach (var pyramid in pyramids)
        { 
            // вызывает Volume() под капотом
            pyramid.Show();
            Console.WriteLine();
        }
    }
    
    private static void PrintHeader(string text)
    {
        var decoration = new string('=', 10);
        Console.WriteLine($"\n{decoration}{text}{decoration}\n");
    }
}