namespace TaskOne.Models;

public class Triangle
{
    private double A { get; set; }
    private double B { get; set; }
    private double AngleAb { get; set; }
    
    private double? C { get; set; }

    public Triangle(double a, double b, double angleAb)
    {
        A = a;
        B = b;
        AngleAb = angleAb;
    }

    public Triangle()
    {
        
    }

    public double GetA()
    {
        return A;
    }
    
    public void SetA(double value)
    {
        A = value;
    }
    
    public double GetB()
    {
        return B;
    }
    
    public void SetB(double value)
    {
        B = value;
    }
    
    public double GetAngleAb()
    {
        return B;
    }
    
    public void SetAngleAb(double value)
    {
        AngleAb = value;
    }

    public double GetC()
    {
        if (C != null)
        {
            return C.Value;
        }

        var angleRad = AngleAb * Math.PI / 180d;
        C = Math.Sqrt(A * A + B * B - 2 * A * B * Math.Cos(angleRad));

        return C.Value;
    }
    
    public double Perimeter()
    {
        return A + B + GetC();
    }

    public double Area()
    {
        var s = Perimeter() / 2d;
        return Math.Sqrt(s * (s - A) * (s - A) * (s - A));
    }
    
    
    public static Triangle operator +(Triangle left, Triangle right)
    {
        var a = left.A + right.A;
        var b = left.B + right.B;
        var avgAngle = (left.AngleAb + left.AngleAb) / 2d;

        return new Triangle(a, b, avgAngle);
    }

    public static Triangle operator *(Triangle left, double scale)
    {
        return new Triangle(left.A * scale, left.B * scale, left.AngleAb);
    }
    
    // В C# нет возможности явно перегрузить префиксный/пост инкремент, данную логику обрабатывает сам компилятор
    // https://stackoverflow.com/a/19141153
    public static Triangle operator ++(Triangle triangle)
    {
        var a = triangle.A + 1;
        var b = triangle.B + 1;
        return new Triangle(a, b, triangle.AngleAb);
    }
    
    public static Triangle operator --(Triangle triangle)
    {
        var a = triangle.A - 1;
        var b = triangle.B - 1;
        return new Triangle(a, b, triangle.AngleAb);
    }

    public override string ToString()
    {
        return $"A:{A}\tB:{B}\tC:{GetC()}\t\tAB Angle:{AngleAb}";
    }
}