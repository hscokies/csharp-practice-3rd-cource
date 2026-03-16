namespace Shared.Geometry.MainTask;

public class Triangle
{
    private double _a;
    private double _b;
    private double? _c;
    private double _angleAb;
    private double AngleAbRad => _angleAb * Math.PI / 180d;

    private double? _area;
    private double? _perimeter;


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
        _c = null;

        _area = null;
        _perimeter = null;
    }
    
    public double GetB()
    {
        return _b;
    }
    public void SetB(double value)
    {
        _b = value;
        _c = null;
        
        _area = null;
        _perimeter = null;
    }
    
    public double GetAngleAb()
    {
        return _angleAb;
    }
    public void SetAngleAb(double value)
    {
        _angleAb = value;
        _c = null;
        
        _area = null;
        _perimeter = null;
    }

    public double GetC()
    {
        if (_c.HasValue)
        {
            return _c.Value;
        }
        
        _c = Math.Sqrt(_a * _a + _b * _b - 2 * _a * _b * Math.Cos(AngleAbRad));

        return _c.Value;
    }

    public double Area()
    {
        if (_area.HasValue)
        {
            return _area.Value;
        }
        
        _area = 0.5 * _a * _b * Math.Sin(AngleAbRad);
        return _area.Value;
    }
    
    public double Perimeter()
    {
        if (_perimeter.HasValue)
        {
            return _perimeter.Value;
        }
        
        _perimeter = _a + _b + GetC();
        return _perimeter.Value;
    }

    // Переопределил метод ToString вместо Show для наглядности наследования
    public virtual void Show()
    {
        Console.WriteLine($"{nameof(Triangle)}\n\t" +
                          $"A:{_a}\n\t" +
                          $"B:{_b}\n\t" +
                          $"C:{GetC()}\n\t" +
                          $"Angle AB:{_angleAb}\n\t" +
                          $"Perimeter:{Perimeter()}\n\t" +
                          $"Area:{Area()}");
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
}