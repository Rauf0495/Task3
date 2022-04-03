using System;

namespace Task3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //7) verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir

        l1:
            Console.Write("Please enter four digit number:");

            int fourDigitNumber = Convert.ToInt32(Console.ReadLine());

            if (!(fourDigitNumber >= 1000 && fourDigitNumber <= 9999))
            {
                Console.Write("Number is not four digit.");
                Console.WriteLine("Please enter four digit number");
                goto l1;
            }
            int res = 0;
            while (fourDigitNumber > 0)
            {
                int res1 = fourDigitNumber % 10;

                fourDigitNumber = (fourDigitNumber - res1) / 10;

                res = res * 10 + res1;

            }
            res = (res * 10 + 8) + 800000;

            Console.WriteLine($"Reversing and adding 8 before first and last digit:{res}");





        }

    }
}
