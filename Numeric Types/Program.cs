using System;

namespace Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length?");
            int dimLength = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the width?");
            int dimWidth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The area is " + (dimLength * dimWidth));

        }
    }
}
