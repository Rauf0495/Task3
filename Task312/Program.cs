using System;

namespace Task312
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //12) 2 dene 5 reqemli eded daxil et.
            //I ededin reqemleri ceminin usutne
            //II ededin reqemleri hasilini gel.
            //Neticenin axirina I ededin en axiinci reqemini artir.

            l1:
            Console.Write("Please enter first five digit number:");

            bool checkfirst5 = int.TryParse(Console.ReadLine(),out int first5DigitNumber);

            if (!(first5DigitNumber >= 10000 && first5DigitNumber <= 99999))
            {

                Console.WriteLine("Number is not five digit.");
                goto l1;

            }
                                
            int copy1 = first5DigitNumber;
        l2:
            Console.Write("Please enter second five digit number:");

            bool checkSecond5 = int.TryParse(Console.ReadLine(), out int second5DigitNumber);

            if (!(second5DigitNumber >= 10000 && second5DigitNumber <= 99999))
            {
                Console.WriteLine("Number is not five digit.");
                goto l2;

            }

            int f5 = 0;
            int s5 = 1;

            while (first5DigitNumber>0)
            {
                f5 = f5 + (first5DigitNumber % 10);

                first5DigitNumber = first5DigitNumber / 10;

            }

            while (second5DigitNumber>0)
            {
                s5 = s5 * (second5DigitNumber % 10);

                second5DigitNumber = second5DigitNumber / 10;

            }

            Console.WriteLine($"Sum of each digit={f5}");
            Console.WriteLine($"Mult of each digit={s5}");
            int sumf5s5 = f5 + s5;
            Console.WriteLine($"{f5}+{s5}={sumf5s5}");

            int result = sumf5s5 * 10 + copy1 % 10;

            Console.WriteLine($"Adding last digit of first five digit number to the result={result}");







        }
    }
}
