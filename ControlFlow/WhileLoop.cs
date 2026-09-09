namespace MyApp.ControlFlow;

public class WhileLoop
{
    public static void CountDown()
    {
        // while loop is usually used when you dont know the number of time your code is to run
        // while (condition)
        // {
        //  code
        // }

        int number = 1;

        while (number <= 5)
        {
            Console.WriteLine(number);
            number++;
        }
    }

    public static void CountUp()
    {

        // Counts up from 5 to 0
        int num = 5;

        while (num >= 1)
        {
            Console.WriteLine(num);
            num--;
        }
    }
}
