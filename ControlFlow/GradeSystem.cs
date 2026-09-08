namespace MyApp.ControlFlow;

public class GradeSystem
{
    public static void Run()
    {
        string guideNote = """
        //////////////// WELCOME TO THE GRADE SYSTEM APP   /////////////////
        /// HERE ARE A FEW STEPS ON HOW TO USE THE APP
        /// FIRST ENTER YOUR FIRSTNAME
        /// CLICK ENTER
        /// SECOND ENTER YOUR SCORE 
        /// CLICK ENTER 
        /// THEN YOUR SHOULD HAVE YOUR GRADE DISLPAYED FOR YOU
        /// THANKS
        """;
        Console.WriteLine(guideNote);
        Console.Write("What is your name?");
        string? name = Console.ReadLine();
        Console.Write("What is your score?");
        string? myScore = Console.ReadLine();
        int score = Convert.ToInt32(myScore);

        if (score >= 70)
        {

            Console.WriteLine($"Congrats {name} you got an A!");
        }
        else if (score >= 60)
        {

            Console.WriteLine($"Congrats {name} you got a B!");
        }
        else if (score >= 50)
        {

            Console.WriteLine($"Congrats {name} you got a C!");

        }
        else if (score >= 45)
        {

            Console.WriteLine($"Congrats {name} you got a D!");

        }
        else if (score >= 40)
        {

            Console.WriteLine($"Congrats {name} you got a E!");

        }

        else
        {
            Console.WriteLine($"I'm sorry {name} but you failed the exam");
        }
    }
};