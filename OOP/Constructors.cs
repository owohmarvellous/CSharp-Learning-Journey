using System.Dynamic;
using System.Reflection.Metadata;

namespace OOP;

public class Car
{
    public string? CarName { get; set; } //These are properties
    public decimal Price { get; set; }
    public int ProductionYear { get; set; }

    //  How to create a Consturctor
    // It must have thesame name as the class 
    //  it must also contain thesame number of fields

    // you can have a default Constructor like the one below
    // You can also have multiple cnstructors.(Constructor Overloading)
    public Car()
    {
        CarName = "";
        Price = 0;
        ProductionYear = 0;
    }


    // One Constructor can have multiple Objects(instances)
    public Car(string name, decimal price, int year)
    {
        CarName = name;
        Price = price;
        ProductionYear = year;

    }


}

public class StudentGrade
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Course { get; set; }
    public decimal GPA { get; set; }

    public StudentGrade(string name, int age)
    : this(name, age, "undeclared", 0) { }
    // {
    //     Name = name;
    //     Age = age;
    //     Course = "Undeclared";
    //     GPA = 0;
    // }
    public StudentGrade(string name, int age, string course, decimal gpa)
    {
        this.Name = name;
        this.Age = age;
        this.Course = course;
        this.GPA = gpa;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Course: {Course}, GPA: {GPA}");
    }

    public bool IsHonorRoll()
    {
        return GPA >= 3.5m;
    }
}


