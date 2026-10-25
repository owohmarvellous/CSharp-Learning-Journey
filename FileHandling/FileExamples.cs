namespace FileHandling;

public class FileExamples
{
    // This method creates a new class
    public void WriteToFile()
    {
        string path = "notes.txt";
        File.WriteAllText(path, "I am learning c-sharp File Handling");
        Console.WriteLine("File Created Successfully");
    }

    // This method is to confirm the informations on this document.
    public void ReadFromFile()
    {
        string path = "notes.txt";
        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    public void AppendFiles()
    {
        string path = "notes.txt";
        File.AppendAllText(path, "Today i learnt something else about handling files in C#");
        Console.WriteLine("New Content Append");
    }

    // we wrote an exception handling for the file notes.txt
    public void SafeToRead()
    {
        string path = "notes.txt";
        try
        {
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The requested file was not found");

        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permission to access this file. ");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"A file operstion fsiled: {ex.Message}");
        }
    }
}