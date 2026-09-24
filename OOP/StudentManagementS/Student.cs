

namespace OOP.StudentManagementS;

public class Student : Person
{
    public int Score { get; private set; }

    // The constructor of the Student class calls the base class constructor to initialize the StudentName and age properties. It also initializes the Score property using the SetScore method.
    public Student(string name, int age, int score)
        : base(name, age, score)
    {
        StudentName = name;
        SetAge(age);
        SetScore(score);
    }

    // The SetScore method is used to set the score of the student. It ensures that the score is between 0 and 100, and if not, it prints an error message.
    public void SetScore(int newScore)
    {
        if (newScore >= 0 && newScore <= 100)
        {
            Score = newScore;
        }
        else
        {
            Console.WriteLine("Score must be between 0 and 100.");
        }
    }

    // The GetGrade method returns the grade of the student based on their score. It uses a series of if statements to determine the grade.
    public string GetGrade()
    {
        if (Score >= 70)
            return "A";

        if (Score >= 60)
            return "B";

        if (Score >= 50)
            return "C";

        if (Score >= 45)
            return "D";

        if (Score >= 40)
            return "E";

        return "F";
    }

    // The Introduce method is overridden from the Person class to provide a more specific introduction for the Student class. It includes the student's name, age, and score in the introduction.
    public override void Introduce()
    {
        Console.WriteLine(
            $"My name is {StudentName}, I am {GetAge()} years old and my score is {Score}."
        );
    }
}