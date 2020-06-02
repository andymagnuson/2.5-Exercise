using System;

namespace MPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            int miles = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons have you used?");
            int gallons = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your current burn rate is " + (miles/gallons) + "MPG");
        }
    }
}
