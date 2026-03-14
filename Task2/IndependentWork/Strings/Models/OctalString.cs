namespace Task2.IndependentWork.Strings.Models;

public class OctalString(string value) : StringValue(value)
{
    protected override int ValueInternal { get; } = Convert.ToInt32(value, 8);
}