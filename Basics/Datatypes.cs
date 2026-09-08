
namespace MyApp.Basics;

public class DataTypes
{
    public static void Run()
    {

        // INTEGER

        // int is used for whole numbers.
        int age = 22;
        int numberOfStudents = 50;

        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Students: {numberOfStudents}");


        // DOUBLE


        // double is commonly used for numbers
        // that contain decimal values.
        double height = 1.75;
        double price = 2500.50;

        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Price: {price}");


        // FLOAT


        // float is another type for decimal numbers.
        // The 'f' tells C# that the number is a float.
        float temperature = 36.5f;

        Console.WriteLine($"Temperature: {temperature}");



        // DECIMAL


        // decimal is commonly preferred when working
        // with financial or monetary calculations.
        // The 'm' tells C# that the value is decimal.
        decimal salary = 500000.75m;

        Console.WriteLine($"Salary: {salary}");



        // STRING


        // string stores text.
        string name = "Chijindu";

        Console.WriteLine($"Name: {name}");



        // CHAR


        // char stores a single character.
        // Characters use single quotes.
        char grade = 'A';

        Console.WriteLine($"Grade: {grade}");



        // BOOL


        // bool can only contain true or false.
        bool isStudent = true;
        bool isLoggedIn = false;

        Console.WriteLine($"Is Student: {isStudent}");
        Console.WriteLine($"Is Logged In: {isLoggedIn}");



        // CONSTANT


        // const means the value cannot be changed
        // after it has been assigned.
        const double Pi = 3.14159;

        Console.WriteLine($"Pi: {Pi}");



        // CHECKING THE TYPE OF A VARIABLE


        Console.WriteLine(age.GetType());
        Console.WriteLine(name.GetType());
        Console.WriteLine(isStudent.GetType());
    }
}