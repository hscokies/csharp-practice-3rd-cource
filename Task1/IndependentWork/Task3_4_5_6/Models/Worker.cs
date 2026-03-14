namespace Task1.IndependentWork.Task3_4_5_6.Models;

internal class Worker : User
{
    private decimal _salary;
    
    public decimal GetSalary() => _salary;

    public void SetSalary(decimal value) => _salary = value;

    public override string ToString()
    {
        return base.ToString() + $"\n\t{nameof(Worker)}\n\tSalary:{_salary}";
    }
}