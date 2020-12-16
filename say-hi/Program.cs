using System;

namespace fcc_tut_vid
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Tony", 8);
        }
        
        static void SayHi(string name, int age) 
        {
            Console.WriteLine($"Hi {name}! You're {age} years old.");
        }
    }
}