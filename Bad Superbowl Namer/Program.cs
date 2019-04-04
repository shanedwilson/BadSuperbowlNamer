using System;

namespace BadSuperbowlNamer
{
    class Program
    {
        static void Main(string[] args)
        {
            var convertor = new RomanNumeralConvertor();

            Console.WriteLine("Please enter the number you would like to convert to Roman numerals");
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your answer is {convertor.ToRoman(input)}");
            Console.WriteLine("Hit enter to continue.");
            Console.ReadKey();
        }
    }
}
