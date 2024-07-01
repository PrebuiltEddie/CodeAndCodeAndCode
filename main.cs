using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to check if it is a perfect number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPerfect(number))
        {
            Console.WriteLine("Perfect Number");
        }
        else
        {
            Console.WriteLine("Not A Perfect Number");
        }
    }

    static bool IsPerfect(int number)
    {
        int sum = 0;

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        return sum == number;
    }
}
