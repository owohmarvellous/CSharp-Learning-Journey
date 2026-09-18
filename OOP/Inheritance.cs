namespace OOP;

// The parent class  
public class Person
{
    public string? Name { get; set; }
    private int Age;
    public string? Gender { get; set; }


    public void Introduce()
    {
        Console.WriteLine($"My name is {Name}, i am {Age} years old and my gender is {Gender}");
    }

    public int GetAge()
    {
        return Age;
    }
    public void SetAge(int newAge)
    {
        if (newAge >= 18 && newAge < 70)
        {
            Age = newAge;
        }
    }
}

// The Inherited class
public class Patient : Person
{
    public decimal Height { get; set; }
}

public class Doctor : Person
{

}
public class Nurse : Person
{

}
public class Cleaner : Person
{
    public void Clean()
    {
        Console.WriteLine($"Mrs {Name} the cleaner is cleaning.");
    }
}