using System;

namespace Task311
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //8 reqemli ededin reqemlerini iki -iki qruplashdir.
        //Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
        //Sonra cavabin ozunden onun 18 % ni cix;

        l1:
            Console.Write("Please enter eight digit number:");

            int eightDigitNumber = Convert.ToInt32(Console.ReadLine());

            if (!(eightDigitNumber >= 10000000 && eightDigitNumber <= 99999999))
            {
                Console.Write("Number is not eight digit.");
                Console.WriteLine("Please enter eight digit number");
                goto l1;
            }

            int[] arr = new int[4];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = eightDigitNumber % 100;

                eightDigitNumber = eightDigitNumber / 100;

            }
            int sumarr = 0;
            foreach (var item in arr)
            {
                sumarr= sumarr+ item;   
            }

            Console.WriteLine(sumarr);

            sumarr = sumarr * 100 + 99;

            sumarr = sumarr - (sumarr * 18 / 100);

            Console.WriteLine(sumarr);



        }
    }
}
