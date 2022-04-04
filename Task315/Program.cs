using System;

namespace Task315
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //* 5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.
            //3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
            //Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
            //Cavabdan 7 reqemli ededin son 5 reqemini cix./1234567
            //Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
            //Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
            //vabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
             l1:
            Console.WriteLine("PLease enter three digit number:");

            bool check1=int.TryParse(Console.ReadLine(),out int tthreeDigitN1);

            if (!(tthreeDigitN1 >= 100&& tthreeDigitN1 <= 999))
            {
                Console.WriteLine("Number is not three digit.");
                goto l1;
            }

            l2:
            Console.WriteLine("PLease enter three digit number:");

            bool check2 = int.TryParse(Console.ReadLine(), out int threeDigitN2);

            if (!(threeDigitN2 >= 100 && threeDigitN2 <= 999))
            {
                Console.WriteLine("Number is not three digit.");
                goto l2;
            }

            l3:
            Console.WriteLine("Please enter  six digit number:");

            bool check3 = int.TryParse(Console.ReadLine(), out int SixDigitN1);

            if (!(SixDigitN1 >= 100000 && SixDigitN1 <= 999999))
            {
                Console.WriteLine("Number is not six digit.");
                goto l3;
            }
             l4:
            Console.WriteLine("Please enter  six digit number:");

            bool check4 = int.TryParse(Console.ReadLine(), out int SixDigitN2);

            if (!(SixDigitN2 >= 100000 && SixDigitN2 <= 999999))
            {
                Console.WriteLine("Number is not six digit.");
                goto l4;
            }

            l5:
            Console.WriteLine("Please enter seven digit number:");

            bool check5 = int.TryParse(Console.ReadLine(), out int sevenDigitN);

            if (!(sevenDigitN >= 1000000 && sevenDigitN <= 9999999))
            {
                Console.WriteLine("Number is not seven digit.");
                goto l5;
            }


            int sumThreeDigitN = threeDigitN2 + tthreeDigitN1;

            Console.WriteLine($"{tthreeDigitN1}+{threeDigitN2}={sumThreeDigitN}");

            double pow2 = Math.Pow((sumThreeDigitN % 100),2);

            Console.WriteLine($"(Last two digits in {sumThreeDigitN})²={pow2}");

            int mergeThree = tthreeDigitN1 * 1000 + threeDigitN2;

            int sumRes1 = (int)pow2 + mergeThree;

            Console.WriteLine($"{pow2}+merged threedigits {mergeThree}={sumRes1}");

            int res2 = sevenDigitN % 100000;

            int res3 = sumRes1 - res2;

            Console.WriteLine($"{sumRes1}- last five digit in seven digit N {res2} ={res3}");

            int sum6N = (SixDigitN1 + SixDigitN2)%1000;

            int res4 = res3 + sum6N;

            Console.WriteLine($"{res3}+{sum6N}={res4}");


            int sumDigit = 0;
            while (sevenDigitN>0) //1234567//28
            {
                int x = sevenDigitN % 10;

                sumDigit = sumDigit + x;

                sevenDigitN = sevenDigitN / 10;
            }

            Console.WriteLine(sumDigit);

            int rev = 0;
            while (sumDigit>0)//28
            {
                int x = sumDigit % 10;               

                rev = rev * 10 + sumDigit;

                sumDigit = sumDigit / 10;
            }

            int sumres4rev = res4 + rev;
            Console.WriteLine($"{res4}+{rev}={sumres4rev}");

            //123456


            int prelast = sumres4rev / 10;

            int last = 123456 % 10;


            prelast = (prelast * 100+88)*10 + last;


            Console.WriteLine(prelast);








        }
    }
}
