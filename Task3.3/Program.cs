using System;

namespace Task3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3) verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi
            l1:
            Console.WriteLine("Please enter nine digit number:");

            int nineDigitNumber = Convert.ToInt32(Console.ReadLine());
                                 

            if (!(nineDigitNumber>=100000000&& nineDigitNumber< 1000000000))
            {
                Console.Write("Number is not nine digit.");
                Console.WriteLine("Please enter nine digit number");
                goto l1;
            }

            nineDigitNumber = nineDigitNumber % 1000000; //456789
            nineDigitNumber = nineDigitNumber / 1000; //456

            int result = 0;

            while (nineDigitNumber>0)
            {
                int result1 = nineDigitNumber % 10;

                nineDigitNumber = (nineDigitNumber - result1) / 10;

                result = result + result1;

            }

            Console.WriteLine($"Sum middle of nine digit number ={result}");





        }
    }
}
