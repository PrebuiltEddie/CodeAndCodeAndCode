using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your message: ");
            string message = Console.ReadLine();

            string result = IsMessageValid(message) ? "Posted" : "Rejected";
            Console.WriteLine(result);
        }

        public static bool IsMessageValid(string message)
        {
            return message.Length <= 140;
        }
    }

