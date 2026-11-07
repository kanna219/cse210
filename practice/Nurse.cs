using System.Security.Cryptography;

class Nurse : Person
{
    private string _speciality;

    public Nurse(string firstName, string lastName, int age, double weigth, string speciality)
    : base(firstName, lastName, age, weight)
    {
        _speciality = speciality;
    }

    public string GetNurseInformation()
    {
        return $"Speciality: {_speciality}: {GetPersonInformation()}";
    }

}