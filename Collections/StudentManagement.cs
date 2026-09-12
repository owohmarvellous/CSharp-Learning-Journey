namespace Collections;

public class StudentManagement
{
    public static void Run()
    {
        // This List stores the student names
        List<string> students = new List<string>()
        {

        "Micheal",
        "Praise",
        "Favor",
        "Ella",
        "Henry"
        };

        // This Dictionary assigns a valuee to the already stored name
        Dictionary<string, int> studentGrades = new Dictionary<string, int>()
        {
            {"Micheal", 76},
            {"Praise", 93},
            {"Favor", 71},
            {"Ella", 45},
            {"Henry", 66},
        };


        //  This foreach loops  runs through the names that have been stored
        foreach (string student in students)
        {
            int score = studentGrades[student];
            Console.WriteLine(student);
            // This if statements check for the students that passed and those that failed
            if (score >= 49)
            {
                Console.WriteLine($"{student} - {score} - PASSED");
            }
            else
            {
                Console.WriteLine($"{student} - {score} - Failed");
            }

        }

    }
}