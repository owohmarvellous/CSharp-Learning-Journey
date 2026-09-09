namespace MyApp.ControlFlow;

public class DoWhile
{
    public static void Run()
    {
        // do
        // {
        //     // Code to repeat
        // }
        // while (condition);

        int number = 1;

        do
        {
            Console.WriteLine(number);
            number++;
        }
        while (number <= 10);
    }
}