namespace TaskOne.Models;

public class Driver : WorkerV3
{
    private byte Expirience { get; set; }
    private LicenseCategory LicenseCategory { get; set; }

    public override string ToString()
    {
        return $"Водитель {Name} возраста {Age} категории {LicenseCategory} со стажем {Expirience} лет";
    }
}

public enum LicenseCategory
{
    A,
    B,
    C
}