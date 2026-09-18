using System.Runtime.CompilerServices;
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
// Student student1 = new Student();
// student1.Name = "Jude";
// student1.Age = 45;
// student1.Score = 66;

// Console.WriteLine($"my name is {student1.Name}");
// Console.WriteLine($"I am  {student1.Age} years old");
// Console.WriteLine($"my score is  {student1.Name}");

// Student student2 = new Student();
// student2.Name = "David";
// student2.Age = 19;
// student2.Score = 93;


// Console.WriteLine($"my name is {student2.Name}");
// Console.WriteLine($"I am  {student2.Age} years old");
// Console.WriteLine($"my score is  {student2.Name}");

// Student student3 = new Student();
// student3.Name = "Lucy";
// student3.Age = 37;
// student3.Score = 80;
// student3.Introduce();

// Console.WriteLine($"my name is {student3.Name}");
// Console.WriteLine($"I am  {student3.Age} years old");
// Console.WriteLine($"my score is  {student3.Name}");

// BankAccount bankAccount = new BankAccount();
// bankAccount.AccountName = "Presious";
// bankAccount.Balance = 550000M;


//  An Object without a Constructor 
Car car1 = new Car("Toyota Camry", 8000000m, 2024);
// car1.CarName = "Toyota Camry";
// car1.Price  = 8000000m;
// car1.ProductionYear = 2024;
Console.WriteLine($"CarName: {car1.CarName}");
Console.WriteLine($"Price: {car1.Price}");
Console.WriteLine($"ProductionYear: {car1.ProductionYear}");


// An Object with a Constructor
Car car2 = new OOP.Car("Mercedes", 40000000M, 2025);
Console.WriteLine($"CarName: {car2.CarName}");
Console.WriteLine($"Price: {car2.Price}");
Console.WriteLine($"ProductionYear: {car2.ProductionYear}");


StudentGrade studentGrade1 = new StudentGrade("Cen jay", 19);
studentGrade1.PrintInfo();


StudentGrade studentGrade2 = new StudentGrade("Frank", 19, "Mathematics", 3.98m);
studentGrade2.PrintInfo();

bool honor = studentGrade2.IsHonorRoll();
Console.WriteLine($"Is the student an honor student? {honor}");

StudentRecord studentRecord1 = new StudentRecord("Victor", 18, "Physics", 4.50m);
studentRecord1.PrintInfo();
// Console.WriteLine(studentRecord1.GetGpa());
// Console.WriteLine($"Name: {studentRecord1.Name}");
// Console.WriteLine($"Course: {studentRecord1.Course}");
// studentRecord1.SetAge(33);
// Console.WriteLine($"Age: {studentRecord1.GetAge()}");
// studentRecord1.SetGpa(3.45m);
// Console.WriteLine($"New GPA: {studentRecord1.GetGpa()}");



