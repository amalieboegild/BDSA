﻿using System;

namespace LeapYear
{
    public class Program
    {
        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Indtast år");
            string reader = Console.ReadLine();
            int input = int.Parse(reader);
            IsLeapYear(input);
        }
    }
}
