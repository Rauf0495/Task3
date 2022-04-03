using System;

namespace Task3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //6) verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et

        l1:
            Console.Write("Please enter eight digit number:");

            int eightDigitNumber = Convert.ToInt32(Console.ReadLine());

            if (!(eightDigitNumber >= 10000000 && eightDigitNumber <= 99999999))
            {
                Console.Write("Number is not eight digit.");
                Console.WriteLine("Please enter eight digit number");
                goto l1;
            }            

            int delFirstDigit = eightDigitNumber % 10000000;

            int delLastDigit = (delFirstDigit- (delFirstDigit % 10))/10;

            Console.WriteLine($"Deleting first and last digit:{delLastDigit}");

        }
    }
}
