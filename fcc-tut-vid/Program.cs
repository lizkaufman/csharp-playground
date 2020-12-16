using System;

namespace fcc_tut_vid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cube(3));
        }
        
        static int Cube(int num) 
        {
            return num * num * num;
        }
    }
}