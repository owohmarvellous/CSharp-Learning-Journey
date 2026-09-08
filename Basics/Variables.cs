
namespace MyApp.Basics;

public class Variables
{
    public static void Run()
    {

        // 1. Declaring and assigning a variable


        // 'int' is the data type.
        // 'age' is the variable name.
        // '22' is the value stored in the variable.
        int age = 22;

        Console.WriteLine(age);



        // 2. Creating a variable first, then
        //    assigning a value later


        int score;

        score = 85;

        Console.WriteLine(score);


        // 3. Changing the value of a variable


        int points = 10;

        Console.WriteLine($"initial point: {points}");

        points = 20;

        Console.WriteLine($"updated point: {points}");


        // 4. Using variables in calculations


        int firstNumber = 10;
        int secondNumber = 5;

        int sum = firstNumber + secondNumber;

        Console.WriteLine($"Sum: {sum}");



        // 5. Using multiple variables


        string firstName = " Marvellous Chijindu";
        string lastName = "Owoh";

        Console.WriteLine($"My Full Name Is {firstName} {lastName}");


        // 6. Variable names should be meaningful


        int studentAge = 22;
        double accountBalance = 150000.50;
        string studentName = "John";

        Console.WriteLine($"My Name Is {studentName}");
        Console.WriteLine($"I Am {studentAge} years old");
        Console.WriteLine($"My Account Balance Is {accountBalance}");


        // 7. Using 'var'


        // C# automatically determines the type
        // based on the value assigned.
        var city = "Enugu";
        var year = 2026;

        Console.WriteLine(city);
        Console.WriteLine(year);
    }
}