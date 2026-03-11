namespace TaskOne.Models;

public class WorkerV3 : User
{
    private decimal Salary { get; set; }
    
    public void SetSalary(decimal value)
    {
        Salary = value;
    }

    public decimal GetSalary()
    {
        return Salary;
    }

    public override string ToString()
    {
        return $"Рабочий {Name} с зарплатой {Salary} и возрастом {Age}";
    }
}