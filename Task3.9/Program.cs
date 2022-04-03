using System;

namespace Task3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //9) 9 reqemli ededdin tek yerde dayananlardan bir eded duzlelt: 132346389=12439

        l1:
            Console.Write("Please enter nine digit number:");

            int nineDigitNumber = Convert.ToInt32(Console.ReadLine());

            int copyN = nineDigitNumber;

            if (!(nineDigitNumber >= 100000000 && nineDigitNumber <= 999999999))
            {
                Console.Write("Number is not nine digit.");
                Console.WriteLine("Please enter nine digit number");
                goto l1;
            }                      

            int res1 = 0;
            int count = 0;

            while (nineDigitNumber>0)
            {
                int pow=(int)Math.Pow(10, count);

                res1 = res1 + (nineDigitNumber % 10) * pow;

                count++;

                nineDigitNumber = nineDigitNumber / 100;

            }

            Console.WriteLine($"Place of odd numbers in {copyN}={res1}");

        
        }
    }
}
