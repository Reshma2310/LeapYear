using System;

namespace LeapYear
{
    internal class Program
    {
        static void Main()
        {
            int year;
            Console.WriteLine("Enter an Year");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year%4 == 0) && (year%100 != 0))
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }
    }
}
