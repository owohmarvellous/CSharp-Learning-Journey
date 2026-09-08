namespace MyApp.Basics;

public class Operators
{
    public static void Run()
    {

        // 1. ARITHMETIC OPERATORS


        int num1 = 10;
        int num2 = 3;

        // Addition
        Console.WriteLine($"Addition: {num1 + num2}");

        // Subtraction
        Console.WriteLine($"Subtraction: {num1 - num2}");

        // Multiplication
        Console.WriteLine($"Multiplication: {num1 * num2}");

        // Division
        Console.WriteLine($"Division: {num1 / num2}");

        // Modulus - gives the remainder
        Console.WriteLine($"Remainder: {num1 % num2}");



        // 2. DECIMAL DIVISION


        // When working with int values,
        // integer division removes the decimal part.
        int number1 = 10;
        int number2 = 3;

        Console.WriteLine($"Integer division: {number1 / number2}");

        // Using double gives a decimal result.
        double decimalResult = 10.0 / 3.0;

        Console.WriteLine($"Decimal division: {decimalResult}");



        // 3. ASSIGNMENT OPERATORS


        int score = 10;

        // Assign
        score = 20;

        Console.WriteLine($"Score: {score}");

        // Add and assign
        score += 5;

        Console.WriteLine($"After += : {score}");

        // Subtract and assign
        score -= 3;

        Console.WriteLine($"After -= : {score}");

        // Multiply and assign
        score *= 2;

        Console.WriteLine($"After *= : {score}");

        // Divide and assign
        score /= 2;

        Console.WriteLine($"After /= : {score}");



        // 4. COMPARISON OPERATORS


        int age = 22;

        // Equal to
        Console.WriteLine(age == 22);

        // Not equal to
        Console.WriteLine(age != 18);

        // Greater than
        Console.WriteLine(age > 18);

        // Less than
        Console.WriteLine(age < 30);

        // Greater than or equal to
        Console.WriteLine(age >= 18);

        // Less than or equal to
        Console.WriteLine(age <= 22);



        // 5. LOGICAL OPERATORS


        bool hasId = true;
        bool isAdult = true;

        // && means AND
        // Both conditions must be true.
        bool canEnter = hasId && isAdult;

        Console.WriteLine($"Can enter: {canEnter}");


        // || means OR
        // At least one condition must be true.
        bool hasMoney = false;
        bool hasCard = true;

        bool canPay = hasMoney || hasCard;

        Console.WriteLine($"Can pay: {canPay}");


        // ! means NOT
        // It reverses a boolean value.
        bool isOnline = true;

        Console.WriteLine($"Is online: {isOnline}");
        Console.WriteLine($"Is offline: {!isOnline}");



        // 6. INCREMENT OPERATOR


        int count = 5;

        // ++ increases the value by 1.
        count++;

        Console.WriteLine($"Count: {count}");



        // 7. DECREMENT OPERATOR


        // -- decreases the value by 1.
        count--;

        Console.WriteLine($"Count: {count}");



        // 8. COMBINING OPERATORS


        int studentScore = 75;

        bool passed = studentScore >= 50;

        Console.WriteLine($"Student passed: {passed}");


        // 9. OPERATOR PRECEDENCE


        int result = 10 + 5 * 2;

        // Multiplication happens before addition.
        // 5 * 2 = 10
        // 10 + 10 = 20
        Console.WriteLine($"Result: {result}");


        // Parentheses can change the order.
        int anotherResult = (10 + 5) * 2;

        // 10 + 5 = 15
        // 15 * 2 = 30
        Console.WriteLine($"Another result: {anotherResult}");
    }
}