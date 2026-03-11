// See https://aka.ms/new-console-template for more information

using TaskOne;

internal class Program
{
    public static void Main(string[] args)
    {
        // Массив объектов
        Triangle[] trianglesCollection =
        [
            new(3, 4, 60),
            new(2, 7, 30),
            new(5, 6, 45),
        ];
        
        // Динамический объект
        dynamic dynamicTriangle = "not a triangle";
        dynamicTriangle = trianglesCollection[0];
        
        // Набор объектов (наверное тут имелся ввиду HashSet<T>)
        var uniqueTriangles = new HashSet<Triangle>(trianglesCollection);


        var triangle = trianglesCollection[0];
        Console.WriteLine("Initial\t\t"+ triangle);
        
        Console.WriteLine("Sum\t\t" + (triangle + triangle));
        Console.WriteLine("Multi\t\t" + (triangle * 3));
        
        Console.WriteLine("Pre-inc\t\t" + ++triangle);
        Console.WriteLine("Post-inc\t" + triangle++);
        Console.WriteLine("Post-inc after\t" + triangle);
        
        Console.WriteLine("Pre-sub\t\t" + --triangle);
        
        Console.WriteLine("Post-sub\t" + triangle--);
        Console.WriteLine("Post-sub after\t" + triangle);
    }
}