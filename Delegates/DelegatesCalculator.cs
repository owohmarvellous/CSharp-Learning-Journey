namespace Delegates;

public class DelegatesCalculator
{
    // Define a delegate that takes two integers and returns an integer
    public delegate int MathOperation(int a, int b);

    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        // Check for division by zero and throw an exception if b is zero
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }

    // 
    public void Run()
    {
        // Create delegate instances for each operation
        MathOperation addOperation = Add;
        MathOperation subtractOperation = Subtract;
        MathOperation multiplyOperation = Multiply;
        MathOperation divideOperation = Divide;
        // assigns values to the variables
        int a = 10;
        int b = 5;
        // calls the delegate instances and prints the results of the operations
        Console.WriteLine($"Addition: {addOperation(a, b)}");
        Console.WriteLine($"Subtraction: {subtractOperation(a, b)}");
        Console.WriteLine($"Multiplication: {multiplyOperation(a, b)}");
        Console.WriteLine($"Division: {divideOperation(a, b)}");
    }
}