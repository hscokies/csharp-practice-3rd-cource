using Task3.IndependentWork.Task4.Models;

namespace Task3.IndependentWork.Task4;

internal static class Sandbox
{
    public static void Main()
    {
        var cpu = new Cpu(InstructionsSet.X86, 1200, 3, "Intel");

        // доступ к атрибутам и методов класса - предка
        // Меняет поле _clockSpeed из Processor
        cpu.Overclock(1.5);
        // Доступ к методу класса Computer component
        cpu.Print();
    }
}