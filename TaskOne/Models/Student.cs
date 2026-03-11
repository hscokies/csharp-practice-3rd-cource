namespace TaskOne.Models;

public class Student : User
{
    private byte Year { get; set; }
    private decimal Stipend { get; set; }

    public byte GetYear()
    {
        return Year;
    }

    private void SetYear(byte value)
    {
        Year = value;
    }

    public decimal GetStipend()
    {
        return Stipend;
    }

    private void SetStipend(decimal value)
    {
        Stipend = value;
    }

    public override string ToString()
    {
        return $"Студент {Name} возраста {Age} на {Year} курсе обучения со стипендией {Stipend}";
    }
}