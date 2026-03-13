// See https://aka.ms/new-console-template for more information

using TaskTwo.models;

internal class Program
{
    public static void Main(string[] args)
    {
        Pyramid[] pyramids =
        [
            new(3, 4, 60, 10),
            new(5, 5, 45, 7),
            new(6, 8, 30, 9),
        ];

        foreach (var pyramid in pyramids)
        {
            // Вызов метода Volume пропускаю т.к. он вызывается в ToString
            Console.WriteLine(pyramid.ToString());
        }
    }
}