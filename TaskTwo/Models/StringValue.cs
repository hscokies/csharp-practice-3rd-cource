namespace TaskTwo.models;

public abstract class StringValue(string value)
{
    public readonly string Value = value;

    protected abstract int ValueInternal { get; }

    public void ShowBin() => Print(nameof(ShowBin), 2); 
    public void ShowOct() => Print(nameof(ShowOct), 8);
    public void ShowDec() => Print(nameof(ShowDec), 10);
    public void ShowHex() => Print(nameof(ShowHex), 16);

    public static int operator +(StringValue left, StringValue right)
    {
        return left.ValueInternal + right.ValueInternal;
    }

    private void Print(string prefix, int notation)
    {
        Console.Write($"{prefix}:{Convert.ToString(ValueInternal, notation)}");
    }
}