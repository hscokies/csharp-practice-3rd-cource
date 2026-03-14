using Shared.Geometry.Primitives;
using Task2.IndependentWork.Shapes.Models;

namespace Task2.IndependentWork.Shapes;

internal static class Sandbox
{
    public static void Main()
    {
        // Существование четырехугольника не имеет смысла т.к. это не явная фигура как трапеция/квадрат, можно использовать общий класс полигон
        var parallelogram = new Polygon(
            new Point(0,0),
            new Point(3,0),
            new Point(4,2),
            new Point(1,2)
        );
        var rectangle = new Rectangle(new Point(10, 10), width: 30, height: 40);
        var square = new Square(new Point(13, -1), side: 10);
        var triangle = new Triangle(new Point(0, 0), new Point(2, 0), new Point(1, 2));
        var pentagon = Pentagon.Create(
            radius: 6,
            center: new Point(2, 3)
        );

        Polygon[] figures = [parallelogram, rectangle, square, triangle, pentagon];
        MoveDemo(figures);
        CompareDemo(figures);
        IntersectDemo(figures);
        IncludesDemo(figures);
    }

    private static void MoveDemo(Polygon[] figures)
    {
        PrintHeader(nameof(MoveDemo));
        
        foreach (var polygon in figures)
        {
            var figureName = polygon.GetType().Name;
            
            Console.WriteLine($"{figureName} before:\n{polygon}\n");
            polygon.Move(10, 31);
            Console.WriteLine($"{figureName} after:\n{polygon}");
            Console.WriteLine(new string('-', 50));
        }
    }

    private static void CompareDemo(Polygon[] figures)
    {
        PrintHeader(nameof(CompareDemo));

        foreach (var outer in figures)
        {
            foreach (var inner in figures)
            {
                var outerName = outer.GetType().Name;
                var innerName = inner.GetType().Name;
                
                Console.WriteLine($"{outerName}\n{outer}\n\n{innerName}\n{inner}");
                var result = outer.Compare(inner);
                switch (result)
                {
                    case <0:
                        Console.WriteLine($"{outerName} area is less than {innerName}");
                        break;
                    case 0:
                        Console.WriteLine($"{outerName} area is equal to {innerName}");
                        break;
                    case >0:
                        Console.WriteLine($"{outerName} area is greater than {innerName}");
                        break;
                            
                }

                Console.WriteLine(new string('-', 50));
            }
        }
    }

    private static void IntersectDemo(Polygon[] figures)
    {
        PrintHeader(nameof(IntersectDemo));
        foreach (var outer in figures)
        {
            foreach (var inner in figures)
            {
                var outerName = outer.GetType().Name;
                var innerName = inner.GetType().Name;
                
                var intersects = outer.Intersects(inner);
                Console.WriteLine(intersects ? $"{outerName} intersects {innerName}" : $"{outerName} doesn't intersect {innerName}");
            }
        }
    }

    private static void IncludesDemo(Polygon[] figures)
    {
        PrintHeader(nameof(IncludesDemo));
        foreach (var outer in figures)
        {
            foreach (var inner in figures)
            {
                var outerName = outer.GetType().Name;
                var innerName = inner.GetType().Name;
                
                var intersects = outer.Includes(inner);
                Console.WriteLine(intersects ? $"{outerName} includes {innerName}" : $"{outerName} doesn't include {innerName}");
            }
        }
    }
    
    private static void PrintHeader(string text)
    {
        var decoration = new string('=', 10);
        Console.WriteLine($"\n{decoration}{text}{decoration}\n");
    }
}