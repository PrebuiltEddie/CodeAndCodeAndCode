using System;

class Program
{
    static void Main()
    {
        decimal totalD = 0, totalE = 0, totalF = 0;
        string input;

        while (true)
        {
            Console.Write("Enter a salesperson initial (D, E, F) or Z to quit: ");
            input = Console.ReadLine().ToUpper();

            if (input == "Z")
                break;

            if (input != "D" && input != "E" && input != "F")
            {
                Console.WriteLine("Error: Invalid initial. Please enter D, E, F, or Z.");
                continue;
            }

            Console.Write("Enter the amount of sale: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal saleAmount) || saleAmount < 0)
            {
                Console.WriteLine("Error: Invalid sale amount. Please enter a positive number.");
                continue;
            }

            switch (input)
            {
                case "D":
                    totalD += saleAmount;
                    break;
                case "E":
                    totalE += saleAmount;
                    break;
                case "F":
                    totalF += saleAmount;
                    break;
            }
        }

        decimal grandTotal = totalD + totalE + totalF;
        string highestSalesperson = GetHighestSalesperson(totalD, totalE, totalF);

        Console.WriteLine($"\nGrand total: {grandTotal:C}");
        Console.WriteLine($"Highest sale: {highestSalesperson}");
    }

    static string GetHighestSalesperson(decimal totalD, decimal totalE, decimal totalF)
    {
        if (totalD >= totalE && totalD >= totalF)
            return "Danielle (D)";
        else if (totalE >= totalD && totalE >= totalF)
            return "Edward (E)";
        else
            return "Francis (F)";
    }
}
