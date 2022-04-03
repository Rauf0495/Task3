using System;

namespace Task3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //8) Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap  

        l1:
            Console.Write("Please enter at least three digit number:");

            long number = Convert.ToInt32(Console.ReadLine());

            if (!(number >= 100))
            {
                Console.Write("Number is not at least three digit.");
                Console.WriteLine("Please enter at least three  number");
                goto l1;
            }          
            long lastDigit = number % 10;

            long lasTwoDigit = number % 100;

            long last3Digit = (number % 1000);

            long result = ((last3Digit - lasTwoDigit)/100)+ lastDigit;

            Console.WriteLine(result);   



        }

        
    }
}
