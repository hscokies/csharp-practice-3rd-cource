namespace Task1.MainTask.Models;

public class Triangle
{
    private double _a;
    private double _b;
    private double? _c;
    private double _angleAb;
    private double AngleAbRad => _angleAb * Math.PI / 180d;


    public Triangle()
    {
        
    }

    public Triangle(double a, double b, double angleAb)
    {
        _a = a;
        _b = b;
        _angleAb = angleAb;
    }

    public double GetA()
    {
        return _a;
    }
    public void SetA(double value)
    {
        _a = value;
    }
    
    public double GetB()
    {
        return _b;
    }
    public void SetB(double value)
    {
        _b = value;
    }
    
    public double GetAngleAb()
    {
        return _angleAb;
    }
    public void SetAngleAb(double value)
    {
        _angleAb = value;
    }

    public double GetC()
    {
        if (_c != null)
        {
            return _c.Value;
        }
        
        _c = Math.Sqrt(_a * _a + _b * _b - 2 * _a * _b * Math.Cos(AngleAbRad));

        return _c.Value;
    }
    
    public double Perimeter()
    {
        return _a + _b + GetC();
    }

    public double Area()
    {
        return 0.5 * _a * _b * Math.Sin(AngleAbRad);
    }
    
    
    public static Triangle operator +(Triangle left, Triangle right)
    {
        var a = left._a + right._a;
        var b = left._b + right._b;
        var avgAngle = (left._angleAb + left._angleAb) / 2d;

        return new Triangle(a, b, avgAngle);
    }

    public static Triangle operator *(Triangle left, double scale)
    {
        return new Triangle(left._a * scale, left._b * scale, left._angleAb);
    }
    
    // В C# нет возможности явно перегрузить префиксный/пост инкремент, данную логику обрабатывает сам компилятор
    // https://stackoverflow.com/a/19141153
    public static Triangle operator ++(Triangle triangle)
    {
        var a = triangle._a + 1;
        var b = triangle._b + 1;
        return new Triangle(a, b, triangle._angleAb);
    }
    
    public static Triangle operator --(Triangle triangle)
    {
        var a = triangle._a - 1;
        var b = triangle._b - 1;
        return new Triangle(a, b, triangle._angleAb);
    }

    public override string ToString()
    {
        return $"{nameof(Triangle)}\n\tA:{_a}\n\tB:{_b}\n\tC:{GetC()}\n\tAngle AB:{_angleAb}";
    }
}