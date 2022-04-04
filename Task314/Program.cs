using System;

namespace Task314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14) 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
            //6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
            //Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
            //Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
            //Neticenin 60 % tap.Cavabin axirina 60 artir.
            //Neticeden 18 % cix.                      

            l1:
            Console.WriteLine("Please enter first six digit number:");

            bool check1 = int.TryParse(Console.ReadLine(), out int firstSixDigitNumber);

            if (!(firstSixDigitNumber >= 100000 && firstSixDigitNumber <= 999999))
            {
                Console.WriteLine("Number is not six digit.");
                goto l1;
            }

            l2:
            Console.WriteLine("Please enter second six digit number:");

            bool check2 = int.TryParse(Console.ReadLine(), out int secondSixDigitNumber);

            if (!(secondSixDigitNumber >= 100000 && secondSixDigitNumber <= 999999))
            {
                Console.WriteLine("Number is not six digit.");
                goto l2;
            }
            l3:
            Console.WriteLine("Please enter third six digit number:");

            bool check3 = int.TryParse(Console.ReadLine(), out int thirdSixDigitNumber);

            if (!(thirdSixDigitNumber >= 100000 && thirdSixDigitNumber <= 999999))
            {
                Console.WriteLine("Number is not six digit.");
                goto l3;
            }

            l4:
            Console.WriteLine("Please enter seven digit number:");

            bool check4 = int.TryParse(Console.ReadLine(), out int sevenDigitNumber);

            if (!(sevenDigitNumber >= 1000000 && sevenDigitNumber <= 9999999))
            {
                Console.WriteLine("Number is not seven digit.");
                goto l4;
            }

            firstSixDigitNumber = firstSixDigitNumber / 1000;
            secondSixDigitNumber = secondSixDigitNumber / 1000;
            thirdSixDigitNumber = thirdSixDigitNumber / 1000;
            int copy = sevenDigitNumber / 1000;
            sevenDigitNumber = sevenDigitNumber % 100000;            

            int sumFirstThree = firstSixDigitNumber + secondSixDigitNumber + thirdSixDigitNumber;

            int sumLastFour = sumFirstThree + sevenDigitNumber;

            int mult = 1;
            while (copy>0)
            {
                int res = copy % 10;

                mult = mult * res;

                copy = copy / 10;

            }


            int result = ((sumLastFour - mult) * 60 / 100) * 100 + 60;

            int lastResult = result - (result * 18 / 100);



            Console.WriteLine(lastResult);






























        }
    }
}
