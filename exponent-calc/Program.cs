using System;

namespace exponent_calc
{
    class Program
    {
      static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What number do you want to start with? ");
            int baseNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What power do you want to multiply it to? ");
            int power = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Your solution is: {GetPower(baseNum, power)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        static int GetPower(int baseNum, int power)
        {
            int result = baseNum;
            for (int i = power; i > 1; i--)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}
