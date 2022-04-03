using System;

namespace Task313
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // 3 dene 5 reqemli eded var.
          //Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
          //Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel.

            l1:
            Console.WriteLine("Please enter first five digit number:");

            bool check1 = int.TryParse(Console.ReadLine(), out int firstFiveDigitNumber);//12345

            if (!(firstFiveDigitNumber >= 10000 && firstFiveDigitNumber <= 99999))
            {
                Console.WriteLine("Number is not five digit.");
                goto l1;
            }

            l2:
            Console.WriteLine("Please enter second five digit number:");

            bool check2 = int.TryParse(Console.ReadLine(), out int secondFiveDigitNumber);

            if (!(secondFiveDigitNumber >= 10000 && secondFiveDigitNumber <= 99999))
            {
                Console.WriteLine("Number is not five digit.");
                goto l2;
            }
            l3:
            Console.WriteLine("Please enter third five digit number:");

            bool check3 = int.TryParse(Console.ReadLine(), out int thirdFiveDigitNumber);

            if (!(thirdFiveDigitNumber >= 10000 && thirdFiveDigitNumber <= 99999))
            {
                Console.WriteLine("Number is not five digit.");
                goto l3;
            }

            int a = 0;
            int b = 0;
            int c = 0;

            
            
            int res1 = firstFiveDigitNumber % 10;

            firstFiveDigitNumber = firstFiveDigitNumber / 10000;

            a = firstFiveDigitNumber * 10 + res1;
            
            int res2 = secondFiveDigitNumber % 10;

            secondFiveDigitNumber = secondFiveDigitNumber / 10000;

            b = secondFiveDigitNumber * 10 + res2;
            
            int res3 = thirdFiveDigitNumber % 10;

            thirdFiveDigitNumber = thirdFiveDigitNumber / 10000;

            c = thirdFiveDigitNumber * 10 + res3;

            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            int sumABC = a + b + c;
            int result = (sumABC * 50 / 100) + sumABC;

            Console.WriteLine(result);
        }
    }
}
