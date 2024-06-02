using System;

class Program
{
    static void Main()
    {
        // Declare the named constant for the number of centimeters in an inch
        const double CENTIMETERS_PER_INCH = 2.54;

        // Declare a variable for the measurement in inches
        double inches;

        // Prompt the user for the measurement in inches and read the input
        Console.Write("Enter the measurement in inches: ");
        inches = Convert.ToDouble(Console.ReadLine());

        // Calculate the measurement in centimeters
        double centimeters = inches * CENTIMETERS_PER_INCH;

        // Display the measurement in both inches and centimeters
        Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
    }
}
