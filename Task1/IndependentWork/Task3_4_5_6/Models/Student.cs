namespace Task1.IndependentWork.Task3_4_5_6.Models;

internal sealed class Student : User
{
    private byte _year;
    private decimal _stipend;

    public byte GetYear() => _year;
    public void SetYear(byte value) => _year = value;

    public decimal GetStipend() => _stipend;

    public void SetStipend(decimal value) => _stipend = value;

    public override string ToString()
    {
        return base.ToString() + $"\n\t{nameof(Student)}\n\tYear:{_year}\n\tStipend:{_stipend}";
    }
}