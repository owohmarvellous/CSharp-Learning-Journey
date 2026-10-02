using System.Runtime.InteropServices;

namespace Delegates;

public class BasicDelegates
{
    public delegate void MessageHandler(string message);

    public void SayHello(string message)
    {
        Console.WriteLine(message);
    }

    public void Run()
    {
        // Creating a delegate instance and assigning a method to it
        // MessageHandler handler = SayHello;
        MessageHandler handler = DisplayMessage;
        handler("Hello from the delegate!");
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message.ToUpper());
    }

}