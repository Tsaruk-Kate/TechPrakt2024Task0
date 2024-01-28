using System;
class Program
{
    static void Main()
    {
        bool exit = false;
        do
        {
            Console.WriteLine("1. Perform calculation");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice (1 or 2): ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                continue;
            }
            switch (choice)
            {
                case 1:
                    PerformCalculation();
                    break;
                case 2:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    break;
            }
        } while (!exit);
    }
    static void PerformCalculation()
    {
        Console.Write("Enter the first number: ");
        if (!double.TryParse(Console.ReadLine(), out double number1))
        {
            Console.WriteLine("Invalid number format. Please enter a number.");
            return;
        }
        Console.Write("Enter the second number: ");
        if (!double.TryParse(Console.ReadLine(), out double number2))
        {
            Console.WriteLine("Invalid number format. Please enter a number.");
            return;
        }

        double sum = number1 + number2;

        Console.WriteLine($"The sum of numbers {number1} and {number2} is: {sum}");
    }
}