namespace MyApp.ControlFlow;

public class ForEach
{
    // foreach loop is commonly used when working with a collection of values.
    public static void Run()
    {
        string[] names = { "Mike", "Jude", "Jane", "John" };

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}