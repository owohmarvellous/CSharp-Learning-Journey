namespace Methods;

public class Method
{
    // This is a method.
    // Methods simply helps you to write a block of code once and reuse it multiple times.
    // static allows us to call the method without creating an object.
    // void tells c-sharp that this method does not return a value.
    public static void SayWelcome()
    {
        Console.WriteLine("Welcome to my application");
    }

    // The command below calls the method but i chose to call mine in program.cs
    // SayWelcome();


    // Methods with parameters.
    public static void Greet(string name)
    {
        Console.WriteLine($"Hello {name} welcome to my application");
    }

    // Methods with multiple parameters.
    public static void Introduce(string name, int age)
    {
        Console.WriteLine($"My name is {name} i am {age} years old");
    }


    //  Return values in methods.
    //  Notice that i did not add the void statement, its because i want this method to actually return a value
    public static int Multiply(int firstNumber, int secondNumber)
    {
        return firstNumber * secondNumber;
    }

    public static bool IsAdult(int age)
    {
        return age >= 18;
    }
    public static void RunIsAdult()
    {

        bool result = IsAdult(33);
        Console.WriteLine(result);
    }


    //  Method Overloading 
    // it means you can have multiple methods with thesame name as long as their parameters are different.
    // C# knows the one you're talking about based on the number of parameters you enter.
    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    public static int Subtract(int num1, int num2, int num3)
    {
        return num1 - num2 - num3;
    }

    // Optional Parameter
    // This allows you to keave an argument blank becuase you've already assigned a default value.

    public static void Greet(string name, string greeting = "Hello")
    {
        Console.WriteLine($"{greeting} my name is {name} i'm glad to be here");
    }

}

//  ALL THE METHODS WERE CALLED IN THE PROGRAM.CS FILE