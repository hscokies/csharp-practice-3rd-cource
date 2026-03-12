namespace TaskTwo.models;

public class Pentagon : Shape
{
    protected override double Area { get; }
    protected override Point[] Polygon { get; }

    private Pentagon(Edge ab, Edge bc, Edge cd, Edge de, Edge ea)
    {
        Polygon =
        [
            ab.Start,
            bc.Start,
            cd.Start,
            de.Start,
            ea.Start
        ];

        var distance = ab.Distance.Value;
        Area = (1d / 4) * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(distance, 2);
    }

    public static Pentagon Create(Edge ab, Edge bc, Edge cd, Edge de, Edge ea)
    {
        double[] distances =
        [
            ab.Distance.Value, bc.Distance.Value,
            cd.Distance.Value, de.Distance.Value,
            ea.Distance.Value
        ];
        
        var isRegular = distances.All(x => Math.Abs(x - distances[0]) < Constants.FloatTolerance);
        if (!isRegular)
        {
            throw new InvalidOperationException("Ожидается правильный пятиугольник");
        }
        
        return new Pentagon(ab, bc, cd, de, ea);
    }
}