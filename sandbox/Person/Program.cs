class Program
{
    public static void Main()
    {
        Person myPerson = new Person("John", "Smith", 45, 185.5);
        Doctor myDoctor = new Doctor("Henry", "Payne", 48, 193, "Bonesaw");
        Police myPolice = new Police("Gary", "Goodman", 61, 181, "Guns");
        List<Person> myPeople = new List<Person>();
        myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);
        foreach (Person person in myPeople)
        {
            if (person is Doctor doctor)
            {
                Console.WriteLine(doctor.GetDoctorInformation());
            }
            else
            {
                Console.WriteLine(person.GetPersonInformation());
            }
        }
    }
}
