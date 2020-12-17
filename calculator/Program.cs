using System;

namespace fcc_tut_vid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Enter your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your operation (+, -, *, or /): ");
            var operation = Console.ReadLine();
            Console.WriteLine("Enter your second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your answer is: ");

            switch (operation)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}