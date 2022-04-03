using System;

namespace Task310
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
        //sonra cut yerde dayanlarinda bir eded duzlet,
        //sonra onlari topla

        l1:
            Console.Write("Please enter nine digit number:");

            int nineDigitNumber = Convert.ToInt32(Console.ReadLine());           

            if (!(nineDigitNumber >= 100000000 && nineDigitNumber <= 999999999))
            {
                Console.Write("Number is not nine digit.");
                Console.WriteLine("Please enter nine digit number");
                goto l1;
            }
                      
            int copy1 = nineDigitNumber*10;
            int count = 0;
            int res = 0;
            while (nineDigitNumber>0)
            {
                int pow = (int)Math.Pow(10, count);

                res = res + (nineDigitNumber % 10) * pow;

                nineDigitNumber = nineDigitNumber / 100;

                count++;    
            }

            Console.WriteLine(res);

            int count1 = 0;
            int res1 = 0;
            while (copy1 > 0)
            {
                int pow1 = (int)Math.Pow(10, count1);

                copy1 = copy1 / 100;

                res1 = res1 + (copy1 % 10) * pow1;               

                count1++;
            }
            
            Console.WriteLine(res1);

            Console.WriteLine($"{res}+{res1}={res+ res1}");





        }
    }
}
