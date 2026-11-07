using System.Security.Cryptography;

class Program
{
    public static void Main()
    {
        Person myPerson = new Person("John", "Smith", 25, 150.0);
        Console.WriteLine(myPerson.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 45, 180.0, "Stethoscope");
        Console.WriteLine(myDoctor.GetdoctorInformation());

        Police myPolice = new Police("Gary", "Goodman", 30, 180.0, "Gun");
        Console.WritrLine(myPolice.GetPoliceInformation());

        Nurse myNurse = new Nurse("Sarah", "Johnson", 32, 130.0, "Emergency");
        Console.WriteLine(myNurse.GetNurseInformation());

        List<Person> myPeople = new List<Person>();
        myPeople.Add(myPerson);
        myPeople.Add(myPolice);
        myPeople.Add(myDoctor);
        myPeople.Add(myNurse);

        foreach (Person person in myPeopel)
        {
            if (person is Doctor doctor)
            {
                Console.WriteLine(doctor.GetDoctorInformation());
            }
            else if (person is Police police)
            {
                Console.WriteLine(police.GetPoliceInforamtion());
            }
            else if (person is Nurse nurse)
            {
                Console.WriteLine(nurse.GetNurseInformation());
            }
            else
            {
                Console.WriteLine(person.GetPersonInformation());
            }
        }

    }
}