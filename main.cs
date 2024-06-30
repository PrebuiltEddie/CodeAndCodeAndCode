using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the wind speed (in miles per hour): ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double windSpeed))
            {
                string category = GetHurricaneCategory(windSpeed);
                Console.WriteLine(category);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static string GetHurricaneCategory(double windSpeed)
        {
            if (windSpeed >= 157)
            {
                return "Category 5 hurricane";
            }
            else if (windSpeed >= 130)
            {
                return "Category 4 hurricane";
            }
            else if (windSpeed >= 111)
            {
                return "Category 3 hurricane";
            }
            else if (windSpeed >= 96)
            {
                return "Category 2 hurricane";
            }
            else if (windSpeed >= 74)
            {
                return "Category 1 hurricane";
            }
            else
            {
                return "Not a hurricane";
            }
        }
    }

