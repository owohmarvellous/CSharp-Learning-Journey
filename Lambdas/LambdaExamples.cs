namespace Lambdas;

public class LambdaExamples
{
    public void Run()
    {
        Func<int, int> numberSquare = (a) => a * a;
        Console.WriteLine(numberSquare(6));

        Func<int, bool> isEven = (number) => number % 2 == 0;
        Console.WriteLine(isEven(70));


        Func<int, int, int> add = (numA, numB) => numA + numB;

        Action<string> greet = name =>
        {
            Console.WriteLine($"Hello {name} welcome to learning lambda");
        };
        greet("Testimony");
    }

}