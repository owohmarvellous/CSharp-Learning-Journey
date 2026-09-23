namespace OOP;

// An interface is like a contract that tells cSharp that any class that inherits from 
// the base class must call the methods in it 
public interface ICar
{
    public abstract void Identify();
}

public class Toyota : ICar
{
    public string? CarName { get; set; }

    public void Identify()
    {
        Console.WriteLine($"The name of the car is {CarName} and it is affordable");
    }
}
public class Lexus : ICar
{
    public string? CarName { get; set; }

    public void Identify()
    {
        Console.WriteLine($"The name of the car is {CarName} and it is giving luxury");
    }
}

// This is an abstract class a class that is designed to be inherited from
public abstract class Animal
{
    public string? animalName { get; set; }
    public string? Sound { get; set; }
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"The {animalName} always {Sound} at night ");
    }
}
public class Lion : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"The {animalName} always {Sound} when people visit the zoo");
    }
}
