using System;

namespace Task3._4
{
    internal class Program


    {
        static void Main(string[] args)
        {
            //4)verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        l1:
            Console.WriteLine("Please enter five digit number:");

            int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());

            if (!(fiveDigitNumber>=10000&& fiveDigitNumber<=99999))
            {
                Console.WriteLine("Number is not five digit.");
                Console.WriteLine("Please enter five digit number");
                goto l1;
            }                     

            double firstDigit = fiveDigitNumber / 10000;
            double lastDigit = fiveDigitNumber % 10;
            double result = (int)Math.Pow(firstDigit + lastDigit, 2);

            Console.WriteLine($"({firstDigit} + {lastDigit})² ={result}");




        }
    }
}
