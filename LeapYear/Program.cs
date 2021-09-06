using System;

namespace LeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Type in a year");
            string reader = Console.ReadLine();
            int input = int.Parse(reader);
            if (IsLeapYear(input))
            {
                System.Console.WriteLine("yay");
            } else {
                System.Console.WriteLine("nay");
            }
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
        
    }
}
