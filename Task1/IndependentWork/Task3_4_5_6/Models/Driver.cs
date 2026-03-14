namespace Task1.IndependentWork.Task3_4_5_6.Models;

internal sealed class Driver : Worker
{
    private byte _experience;
    private LicenseCategory _licenseCategory;

    public byte GetExperience() => _experience;
    public void SetExperience(byte experience) => _experience = experience;
    
    public LicenseCategory GetLicenseCategory() => _licenseCategory;
    public void SetLicenseCategory(LicenseCategory licenseCategory) => _licenseCategory = licenseCategory;

    public override string ToString()
    {
        return base.ToString() + $"\n{nameof(Driver)}\n\tExperience:{_experience}\n\tLicense:{_licenseCategory}";
    }
}

internal enum LicenseCategory
{
    A,
    B,
    C
}