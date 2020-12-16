using System;
using System.Collections.Generic;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
         {
            var fibonacciNumbers = new List<int> { 1, 1 };

            for (int i = 0; i <= 20; i++)
            {
                int previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                int previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
        }
    }
}
