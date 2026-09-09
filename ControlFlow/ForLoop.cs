namespace MyApp.ControlFlow;

public class ForLoop
{
    // The basic loop structure
    //  for (starting point; condition; increment)
    // {
    //   code to repeat
    // }
    public static void Run()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Counts from 10 to 1
        for (int a = 10; a >= 1; a--)
        {
            Console.WriteLine(a);
        }
    }
};