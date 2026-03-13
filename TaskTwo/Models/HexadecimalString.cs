namespace TaskTwo.models;

public class HexadecimalString(string value) : StringValue(value)
{
    protected override int ValueInternal { get; } = Convert.ToInt32(value, 16);
}