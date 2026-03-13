namespace TaskTwo.models;

public class OctalString(string value) : StringValue(value)
{
    protected override int ValueInternal { get; } = Convert.ToInt32(value, 8);
}