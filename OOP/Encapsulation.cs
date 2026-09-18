using System.Security.Cryptography;

namespace OOP;

public class StudentRecord
{
    public string? Name { get; set; }
    private int Age { get; set; }
    public string? Course { get; set; }
    private decimal GPA; // We use private to prevent the decimal from being accessed from  outside the class 

    // The Constructor for the class
    public StudentRecord(string name, int age, string course, decimal gpa)
    {
        Name = name;
        Course = course;

        // This first tells the GPA howfar not to go(Rules)
        if (gpa >= 0 && gpa <= 5.0m)
        {
            this.GPA = gpa;
        }
        else
        {
            this.GPA = 0;
        }
        if (age >= 18 && age <= 70)
        {
            this.Age = age;
        }
        else
        {
            this.Age = 0;
        }
    }
    public int GetAge()
    {
        return Age;
    }

    public void SetAge(int newAge)
    {
        if (newAge >= 18 && newAge <= 70)
        {
            Age = newAge;
        }
    }
    // Gets the value of the private field (GPA)
    public decimal GetGpa()
    {
        return GPA;
    }

    // Sets another Private value by defining a boundary(The scope of its use) for it 
    public void SetGpa(decimal newGpa)
    {
        if (newGpa >= 0 && newGpa <= 5.0m)
        {
            GPA = newGpa;
        }
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Course: {Course}, GPA: {GPA}");
    }


}