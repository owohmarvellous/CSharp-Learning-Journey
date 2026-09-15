using Collections;
using Methods;
using Myapp.ControFlow;
using MyApp.ControlFlow;
using MyApp.NumberGuess;
using OOP;
// IfStatement.Run();
// ElseIf.Run();
// Switch.Run();
// GradeSystem.Run();
// FizzBuzz.Run();
// TrafficLight.Shine();
// Calculator.Calculate();
// ForLoop.Run();
// WhileLoop.CountDown();
// DoWhile.Run();
// ForEach.Run();
// NumberGuess.WhileGuess();
// NumberGuess.ForGuess();
// Method.Greet("Jack");
// Method.Greet("Mike");
// Method.SayWelcome();
// MethodCalculator.Calculate();
// Method.RunIsAdult();
// Collections.Arrays.Run();
// StudentManagement.Run();
// $

// This an object of a class
Student student1 = new Student();
student1.Name = "Jude";
student1.Age = 45;
student1.Score = 66;

Console.WriteLine($"my name is {student1.Name}");
Console.WriteLine($"I am  {student1.Age} years old");
Console.WriteLine($"my score is  {student1.Name}");

Student student2 = new Student();
student2.Name = "David";
student2.Age = 19;
student2.Score = 93;


Console.WriteLine($"my name is {student2.Name}");
Console.WriteLine($"I am  {student2.Age} years old");
Console.WriteLine($"my score is  {student2.Name}");

Student student3 = new Student();
student3.Name = "Lucy";
student3.Age = 37;
student3.Score = 80;
student3.Introduce();

Console.WriteLine($"my name is {student3.Name}");
Console.WriteLine($"I am  {student3.Age} years old");
Console.WriteLine($"my score is  {student3.Name}");

BankAccount bankAccount = new BankAccount();
bankAccount.AccountName = "Presious";
bankAccount.Balance = 550000M;


