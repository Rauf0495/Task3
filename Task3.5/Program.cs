using System;

namespace Task3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //5) verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
        l1:
            Console.WriteLine("Please enter six digit number:");

            int sixDigitNumber = Convert.ToInt32(Console.ReadLine());

            if (!(sixDigitNumber >= 100000 && sixDigitNumber <= 999999))
            {
                Console.Write("Number is not six digit.");
                Console.WriteLine("Please enter six digit number");
                goto l1;
            }          

            int firstDigit = sixDigitNumber / 100000;

            int addToLast = sixDigitNumber * 10 + firstDigit;

            Console.WriteLine($"Adding {firstDigit} to {sixDigitNumber}={addToLast}");









        }
    }
}
