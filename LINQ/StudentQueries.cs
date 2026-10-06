namespace LINQ;

public class Student
{
    public string? Name { get; set; }
    public int Score { get; set; }

    public void StudentScore()
    {

        List<Student> students = new List<Student>
        {
            new Student {Name = "John", Score = 95},
            new Student {Name = "Favour", Score = 84},
            new Student {Name = "David", Score = 61},
            new Student {Name = "John", Score = 59},
            new Student {Name = "John", Score = 45},

        };
        var passedStudents = students.Where(student => student.Score >= 50);
        foreach (Student student in passedStudents)
        {
            Console.WriteLine(student.Name);
        }

        var topStudents = students.Where(student => student.Score >= 70).OrderByDescending(student => student.Score);
        foreach (Student student in topStudents)
        {
            Console.WriteLine($"Top peformer:{student.Name}: {student.Score}");
        }

        var studentNames = students.Where(name => name.Score >= 70).Select(student => student.Name);
        Console.WriteLine("This Returns the names of the Top scoring students");

        foreach (string? name in studentNames)
        {
            Console.WriteLine(name);
        }

        bool isExcellent = students.Any(student => student.Score >= 90);
        Console.WriteLine("This confirms that a student performed high ");
        Console.WriteLine(isExcellent);


        var studentCount = students.Count(student => student.Score <= 50);

        Console.WriteLine(studentCount);

    }

}