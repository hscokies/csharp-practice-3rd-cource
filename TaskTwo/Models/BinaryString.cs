using System.Globalization;

namespace TaskTwo.models;

public class BinaryString(string value) : StringValue(value)
{
    protected override int ValueInternal { get; } = Convert.ToInt32(value, 2);
}