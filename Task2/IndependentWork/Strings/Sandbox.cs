using System.Diagnostics;
using Task2.IndependentWork.Strings.Models;

namespace Task2.IndependentWork.Strings;

internal static class Sandbox
{
    public static void Main()
    {
        StringValue[] values =
        [
            new BinaryString("10011101"),
            new DecimalString("157"),
            new HexadecimalString("9d"),
            new OctalString("235"),
        ];

        foreach (var value in values)
        {
            Console.WriteLine(value.GetType().Name);
            value.ShowBin();
            value.ShowOct();
            value.ShowDec();
            value.ShowHex();
            Console.WriteLine("\n");
        }

        var result = (values[0] + values[1]) / 2;
        Debug.Assert(result == 157);
    }
}