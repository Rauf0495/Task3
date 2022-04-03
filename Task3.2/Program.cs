using System;

namespace Task3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3

            Console.WriteLine("Please enter six digit number");
            l1:
            int sixDigitNumber=Convert.ToInt32(Console.ReadLine());

            sixDigitNumber = Math.Abs(sixDigitNumber);

            int result2 = 0;

            if (sixDigitNumber>=100000&&sixDigitNumber<=999999)
            {
                int hide = sixDigitNumber / 1000;

               

                while (hide>0)
                {
                   int result = hide % 10;

                   hide = (hide - result) / 10;

                    result2 = result2 + result;
                }
            }
            

            else
            {
                Console.Write("Number is not six digit.");
                Console.WriteLine("Please enter six digit number");

                goto l1;
            }

            Console.WriteLine($"Sum of six digit={result2}");
            
        }
    }
}
