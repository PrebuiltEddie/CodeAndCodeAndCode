using System;
using System.IO;

class Program
{
    private static string stateFilePath = "state.txt";

    public static void Main(string[] args)
    {
        int state = GetState();
        switch (state)
        {
            case 1:
                DisplayLyrics1();
                break;
            case 2:
                DisplayLyrics2();
                break;
            case 3:
                DisplayLyrics3();
                break;
            case 4:
                DisplayLyrics4();
                break;
            default:
                Console.WriteLine("Invalid state.");
                break;
        }
        UpdateState(state);
    }

    private static int GetState()
    {
        if (!File.Exists(stateFilePath))
        {
            File.WriteAllText(stateFilePath, "1");
            return 1;
        }

        string stateText = File.ReadAllText(stateFilePath);
        if (int.TryParse(stateText, out int state))
        {
            return state;
        }
        else
        {
            File.WriteAllText(stateFilePath, "1");
            return 1;
        }
    }

    private static void UpdateState(int currentState)
    {
        int nextState = (currentState % 4) + 1;
        File.WriteAllText(stateFilePath, nextState.ToString());
    }

    public static void DisplayLyrics1()
    {
        Console.WriteLine("Oh, well imagine /");
        Console.WriteLine("As I'm pacing the pews in a church corridor /");
        Console.WriteLine("And I can't help but to hear /");
        Console.WriteLine("No, I can't help but to hear an exchanging of words...");
        Console.WriteLine();
    }

    public static void DisplayLyrics2()
    {
        Console.WriteLine("Oh-oh-oh-oh-oh,");
        Console.WriteLine();
        Console.WriteLine("oh-oh-oh-oh,");
        Console.WriteLine();
        Console.WriteLine("oh-oh-oh /");
        Console.WriteLine("Caught in a bad romance...");
        Console.WriteLine();
    }

    public static void DisplayLyrics3()
    {
        Console.WriteLine("Coming out of my cage");
        Console.WriteLine("And I've been doing just fine");
        Console.WriteLine("Gotta gotta be down");
        Console.WriteLine("Because I want it all");
        Console.WriteLine();
    }

    public static void DisplayLyrics4()
    {
        Console.WriteLine("Now, this is a story all about how");
        Console.WriteLine("My life got flipped-turned upside down");
        Console.WriteLine("And I'd like to take a minute");
        Console.WriteLine("Just sit right there");
        Console.WriteLine("I'll tell you how I became the prince of a town called Bel-Air");
        Console.WriteLine();
    }
}
