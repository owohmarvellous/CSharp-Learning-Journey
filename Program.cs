using System.Runtime.CompilerServices;
using Collections;
using ExceptionHandling;
using Generics;
using Methods;
using Myapp.ControFlow;
using MyApp.ControlFlow;
using MyApp.NumberGuess;
using Nullable;
// using OOP;
// using OOP.StudentManagementS;
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
// Car car1 = new Car("Toyota Camry", 8000000m, 2024);
// // car1.CarName = "Toyota Camry";
// // car1.Price  = 8000000m;
// // car1.ProductionYear = 2024;
// Console.WriteLine($"CarName: {car1.CarName}");
// Console.WriteLine($"Price: {car1.Price}");
// Console.WriteLine($"ProductionYear: {car1.ProductionYear}");


// // An Object with a Constructor
// Car car2 = new OOP.Car("Mercedes", 40000000M, 2025);
// Console.WriteLine($"CarName: {car2.CarName}");
// Console.WriteLine($"Price: {car2.Price}");
// Console.WriteLine($"ProductionYear: {car2.ProductionYear}");


// StudentGrade studentGrade1 = new StudentGrade("Cen jay", 19);
// studentGrade1.PrintInfo();


// StudentGrade studentGrade2 = new StudentGrade("Frank", 19, "Mathematics", 3.98m);
// studentGrade2.PrintInfo();

// bool honor = studentGrade2.IsHonorRoll();
// Console.WriteLine($"Is the student an honor student? {honor}");

// StudentRecord studentRecord1 = new StudentRecord("Victor", 18, "Physics", 4.50m);
// studentRecord1.PrintInfo();
// Console.WriteLine(studentRecord1.GetGpa());
// Console.WriteLine($"Name: {studentRecord1.Name}");
// Console.WriteLine($"Course: {studentRecord1.Course}");
// studentRecord1.SetAge(33);
// Console.WriteLine($"Age: {studentRecord1.GetAge()}");
// studentRecord1.SetGpa(3.45m);
// Console.WriteLine($"New GPA: {studentRecord1.GetGpa()}");


// Patient patient = new Patient();
// patient.Name = "Victory";
// // patient.Age = 34;
// patient.Gender = "Male";
// patient.Height = 6.55m;

// patient.GetAge();
// patient.SetAge(34);

// // You can also use the method from the base class
// patient.Introduce();

// Console.WriteLine($"Height:{patient.Height}");

// Cleaner cleaner = new Cleaner();
// cleaner.Name = "Mary";
// cleaner.Clean();

// Doctor doctor = new Doctor();
// doctor.Name = "Mike";
// doctor.Gender = "Male";
// doctor.GetAge();
// doctor.SetAge(45);

// doctor.Introduce();

// Nurse nurse = new Nurse();
// nurse.Name = "Lucy";
// nurse.Gender = " Female";

// nurse.GetAge();
// nurse.SetAge(40);
// nurse.Introduce();

// Occupation occupation = new Occupation();
// occupation.Name = "Luke";
// occupation.Job = " Engineer";

// occupation.Introduce();

// // We can write the object like this because of inheritance.
// Occupation lecturer = new Lecturer();
// lecturer.Name = "Mike";
// lecturer.Job = " Lecturer";

// lecturer.Introduce();

// Occupation carpenter = new Carpenter();
// carpenter.Name = "Favour";
// carpenter.Job = " Carpenter";

// carpenter.Introduce();

// ICar toyota = new Toyota();
// ICar lexus = new Lexus();

// toyota.Identify();
// lexus.Identify();

// // you cannot create an abtstract class object directly
// // Animal animal = new Animal(); ---> this wont work
// Animal dog = new Dog();
// dog.animalName = "Dog";
// dog.Sound = "Barks";

// dog.MakeSound();
// Animal lion = new Lion();
// lion.animalName = "Dog";
// lion.Sound = "Barks";

// // lion.MakeSound();

// // List<Student> students = new List<Student>();
// //  DisplayStudents(students)


// // This is the main entry point of the application. It creates an instance of the StudentManagementSystem class and calls its Run method to start the application.
// StudentManagementSystem system = new StudentManagementSystem();

// system.Run();

//  Observe that thesame method handles int, string, bool, and double
// GenericMethods genericmethods = new GenericMethods();

// genericmethods.Print(143);
// genericmethods.Print("Welcome to Generics");
// genericmethods.Print(true);
// genericmethods.Print(16.3);

// Box<int> intBox = new Box<int>(42);
// Box<string> stringBox = new Box<string>("This is Generics in a class");
// Box<double> doubleBox = new Box<double>(3.14);

// intBox.PrintValue();
// stringBox.PrintValue();
// doubleBox.PrintValue();

// GenericStorage<int> intStorage = GenericStorage<int>.Create(455);
// GenericStorage<string> stringStorage = GenericStorage<string>.Create("Hello, Generics!");
// GenericStorage<double> doubleStorage = GenericStorage<double>.Create(44.69);

// Console.WriteLine($"Stored integer: {intStorage.GetItem()}");
// Console.WriteLine($"Stored string: {stringStorage.GetItem()}");
// Console.WriteLine($"Stored double: {doubleStorage.GetItem()}");

// BasicException basicException = new BasicException();
// // basicException.Run();
// // basicException.Divide();
// basicException.GetAge();

// BankAccount bankAccount = new BankAccount(0m);
// try
// {
//     bankAccount.Deposit();
//     bankAccount.Withdraw();


// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Invalid Input: {ex.Message}");
// }
// catch (InvalidOperationException ex)
// {
//     Console.WriteLine(ex.Message);
// }
// Console.WriteLine($"Main Balance: #{bankAccount.GetBalance():N2}");

User user = new User();
user.DisplayContact();

