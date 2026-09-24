namespace OOP.StudentManagementS;

public class Person
{
    public string StudentName { get; set; }

    private int age;  // We are using Encapsulation

    // This is a Constructor
    public Person(string name, int age, int Score)
    {
        StudentName = name;
        SetAge(age);
    }


    public int GetAge()
    {
        return age;
    }

    // Defining the scope of the Encapsulation.
    public void SetAge(int newAge)
    {
        if (newAge >= 16 && newAge <= 100)
        {
            age = newAge;
        }
        else
        {
            Console.WriteLine("Age must be between 16 and 100.");
        }
    }

    // We used the virtual keyword to allow derived classes to override this method.
    public virtual void Introduce()
    {
        Console.WriteLine($"My name is {StudentName} and I am {GetAge()} years old.");
    }
}