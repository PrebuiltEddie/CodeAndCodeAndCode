using System;

class Program
{
    static void Main(string[] args)
    {
        // Constants for the moving rates
        const double baseRate = 200.0;
        const double ratePerHour = 150.0;
        const double ratePerMile = 2.0;

        // Prompt the user for the number of hours
        Console.Write("Enter the estimated number of hours for the move: ");
        double hours = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the number of miles
        Console.Write("Enter the estimated number of miles for the move: ");
        double miles = Convert.ToDouble(Console.ReadLine());

        // Calculate the total moving fee
        double totalFee = baseRate + (ratePerHour * hours) + (ratePerMile * miles);

        // Display the total moving fee
        Console.WriteLine("The total moving fee is: $" + totalFee);
    }
}
