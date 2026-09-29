namespace Generics;


// Generics allows you to write one reuseable that can work with differrent datatypes
public class GenericMethods
{

    public void Print<T>(T value)
    {
        Console.WriteLine(value);
    }
}

public class Box<T>
{
    public T Value { get; set; }

    public Box(T value)
    {
        Value = value;
    }

    public void PrintValue()
    {
        Console.WriteLine($"Box contains: {Value}");
    }
}
