using System;

namespace Task3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) verilmish 4 reqemli ededin reqemlerinin cemini tap

            Console.Write("Please enter four digit number:");
        l1:
            int fourDigitNumber = Convert.ToInt32(Console.ReadLine());

            fourDigitNumber = Math.Abs(fourDigitNumber);

            int result1 = 0;

            if (fourDigitNumber >= 1000&& fourDigitNumber <= 9999)

            {                
                while (fourDigitNumber > 0)
                {                                       
                    int result = fourDigitNumber % 10;

                    result1 = result1 + result;

                    fourDigitNumber = (fourDigitNumber - result) / 10;

                }
            }
            else
            {
                Console.Write("Number is not four digit.");
                Console.WriteLine("Please enter four digit number");

                goto l1;
            }

            

            Console.WriteLine($"Sum of digits={result1}");

        }
    }
}
