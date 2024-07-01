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
        int contestantsLastYear = 0;
        int contestantsCurrentYear = 0;
        int ticketPrice = 25; // Assuming ticket price for calculation

        // Prompt user for input
        Console.Write("Enter the number of contestants last year: ");
        if (!int.TryParse(Console.ReadLine(), out contestantsLastYear))
        {
            Console.WriteLine("Invalid input for contestants last year. Please enter a valid number.");
            return;
        }

        Console.Write("Enter the number of contestants this year: ");
        if (!int.TryParse(Console.ReadLine(), out contestantsCurrentYear))
        {
            Console.WriteLine("Invalid input for contestants this year. Please enter a valid number.");
            return;
        }

        // Calculate revenue
        int revenueExpected = contestantsCurrentYear * ticketPrice;

        // Compare contestant numbers and output results
        if (contestantsCurrentYear > 2 * contestantsLastYear)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (contestantsCurrentYear > contestantsLastYear)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }

        Console.WriteLine($"Last year's competition had {contestantsLastYear} contestants, and this year's has {contestantsCurrentYear} contestants");
        Console.WriteLine($"Revenue expected this year is ${revenueExpected}");
    }
}
