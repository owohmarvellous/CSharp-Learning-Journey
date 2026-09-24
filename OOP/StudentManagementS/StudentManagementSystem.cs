

namespace OOP.StudentManagementS;


public class StudentManagementSystem
{
    // This is a list to store the students in the system.
    private readonly List<Student> students = new List<Student>();


    public void Run()
    {
        // This is a loop that will keep the program running until the user chooses to exit.
        bool running = true;

        while (running)
        {
            // This is a method that will display the menu options to the user.
            DisplayMenu();

            Console.Write("Choose an option: ");
            string? choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;

                case "2":
                    DisplayStudents();
                    break;

                case "3":
                    SearchStudent();
                    break;

                case "4":
                    UpdateScore();
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Thank you for using the Student Management System.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose from option 1-5.");
                    break;
            }

            Console.WriteLine();
        }
    }

    //   This is the actual body of the  method that will display the menu options to the user.
    private void DisplayMenu()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("     STUDENT MANAGEMENT SYSTEM");
        Console.WriteLine("=================================");
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. View Students");
        Console.WriteLine("3. Search Student");
        Console.WriteLine("4. Update Score");
        Console.WriteLine("5. Exit");
        Console.WriteLine("=================================");
    }

    //  This is the actual body of the method that will add a student to the system.
    private void AddStudent()
    {
        Console.Write("Enter student name: ");
        string? name = Console.ReadLine();

        // This is a validation check to ensure that the student name is not empty or whitespace.
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Student name cannot be empty.");
            return;
        }

        Console.Write("Enter student age: ");
        string? ageInput = Console.ReadLine();

        // This is a validation check to ensure that the student age is a valid integer and within the range of 16 to 100.
        if (!int.TryParse(ageInput, out int age))
        {
            Console.WriteLine("Please enter a valid age.");
            return;
        }

        if (age < 16 || age > 100)
        {
            Console.WriteLine("Age must be between 1 and 100.");
            return;
        }

        Console.Write("Enter student score: ");
        string? scoreInput = Console.ReadLine();

        // This is a validation check to ensure that the student score is a valid integer and within the range of 0 to 100.
        if (!int.TryParse(scoreInput, out int score))
        {
            Console.WriteLine("Please enter a valid score.");
            return;
        }

        if (score < 0 || score > 100)
        {
            Console.WriteLine("Score must be between 0 and 100.");
            return;
        }

        Student student = new Student(name, age, score);

        students.Add(student);

        Console.WriteLine("Student added successfully!");
    }

    // This is the actual body of the method that will display the students in the system.
    private void DisplayStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students have been added yet.");
            return;
        }

        Console.WriteLine("========== STUDENTS ==========");

        for (int i = 0; i < students.Count; i++)
        {
            Student student = students[i];

            Console.WriteLine($"Student #{i + 1}");
            Console.WriteLine($"Name: {student.StudentName}");
            Console.WriteLine($"Age: {student.GetAge()}");
            Console.WriteLine($"Score: {student.Score}");
            Console.WriteLine($"Grade: {student.GetGrade()}");
            Console.WriteLine("------------------------------");
        }
    }

    // This is the actual body of the method that will search for a student in the system.
    private void SearchStudent()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students have been added yet.");
            return;
        }

        Console.Write("Enter student name to search: ");
        string? searchName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(searchName))
        {
            Console.WriteLine("Search name cannot be empty.");
            return;
        }

        // This is a boolean variable that will be used to check if the student was found in the system.
        bool found = false;

        foreach (Student student in students)
        {
            if (student.StudentName.Equals(
                searchName,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Student found!");
                Console.WriteLine($"Name: {student.StudentName}");
                Console.WriteLine($"Age: {student.GetAge()}");
                Console.WriteLine($"Score: {student.Score}");
                Console.WriteLine($"Grade: {student.GetGrade()}");

                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Student not found.");
        }
    }

    // This is the actual body of the method that will update a student's score in the system.
    private void UpdateScore()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students have been added yet.");
            return;
        }

        Console.Write("Enter student name: ");
        string? name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be empty.");
            return;
        }

        Student? studentToUpdate = null;

        foreach (Student student in students)
        {
            if (student.StudentName.Equals(
                name,
                StringComparison.OrdinalIgnoreCase))
            {
                studentToUpdate = student;
                break;
            }
        }

        if (studentToUpdate == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        Console.Write("Enter new score: ");
        string? scoreInput = Console.ReadLine();

        if (!int.TryParse(scoreInput, out int newScore))
        {
            Console.WriteLine("Please enter a valid score.");
            return;
        }

        if (newScore < 0 || newScore > 100)
        {
            Console.WriteLine("Score must be between 0 and 100.");
            return;
        }

        studentToUpdate.SetScore(newScore);

        Console.WriteLine("Score updated successfully!");
        Console.WriteLine($"New grade: {studentToUpdate.GetGrade()}");
    }
}