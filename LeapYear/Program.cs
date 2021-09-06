using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Type in a year");
            string reader = Console.ReadLine();
            
            try 
            {
                int input = int.Parse(reader);
                if (IsLeapYear(input))
                {
                    System.Console.WriteLine("yay");
                } else {
                    System.Console.WriteLine("nay");
                }
            } catch (ArgumentException ae) 
            {
                System.Console.WriteLine(ae.Message);
            } catch (FormatException)
            {
                System.Console.WriteLine("The year must be a number"); 
            }
        }

        public static bool IsLeapYear(int year)
        {
            if (year<1582)
            {
                throw new ArgumentException("The year must be after 1582");   
            }
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
