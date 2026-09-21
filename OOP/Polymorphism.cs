namespace OOP;

public class Occupation
{
    public string? Name { get; set; }
    public string? Job { get; set; }

    // The virtual here tells C-sharp to all a derived class to be able to edit this method
    public virtual void Introduce()
    {
        Console.WriteLine($"My name is {Name} and i am a {Job}");
    }

}

public class Lecturer : Occupation
{
    // overide means i'm changing the behaviour of the inherited method.
    public override void Introduce()
    {
        Console.WriteLine($"My Name is {Name} and i am a {Job} at UNN ");
    }
}

public class Carpenter : Occupation
{
    public override void Introduce()
    {
        Console.WriteLine($"My name is {Name} and i a {Job} and i really love what i do");
    }
}