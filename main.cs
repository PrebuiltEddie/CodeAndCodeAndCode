using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************\n");

        bool exitRequested = false;

        while (!exitRequested)
        {
            DisplayMenu();
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    CalculateRevenueAndComparison();
                    break;
                case "2":
                    exitRequested = true;
                    Console.WriteLine("\nThank you for using the Greenville Revenue App, good-bye!");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter 1 or 2.");
                    break;
            }

            Console.WriteLine(); // Blank line for readability after each action
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Please Enter the following number below from the following menu:\n");
        Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit");
    }

    static void CalculateRevenueAndComparison()
    {
        // Mock data for testing purposes
        int contestantsLastYear = 122;
        int contestantsCurrentYear = 426;
        int ticketPrice = 25; // Assuming ticket price for calculation

        // Calculate revenue
        int revenueExpected = contestantsCurrentYear * ticketPrice;

        // Compare contestant numbers
        bool isBigger = contestantsCurrentYear > contestantsLastYear;

        // Output results
        Console.WriteLine($"Last year's competition had {contestantsLastYear} contestants, and this year's has {contestantsCurrentYear} contestants");
        Console.WriteLine($"Revenue expected this year is ${revenueExpected}");

        if (isBigger)
        {
            Console.WriteLine("It is true that this year's competition is bigger than last year's.");
        }
        else
        {
            Console.WriteLine("This year's competition is not bigger than last year's.");
        }
    }
}
