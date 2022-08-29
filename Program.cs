using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int nValue;
            int leftBorder=1;
            int rightBorder=27;
            int maxNaturalThreeDigitNumber = 999;
            int minNaturalThreeDigitNumber = 100;
            int numberToCheck = 0;
            int countNaturalThreeDigitNumber=0;

            Random random = new Random();
            nValue = random.Next(leftBorder, ++rightBorder);
            Console.WriteLine("Дано N = " + nValue);
            Console.WriteLine("Трехзначные натуральные числа, которые кратны N:");

            for (int i= numberToCheck; i<=maxNaturalThreeDigitNumber; i++)
            {
                numberToCheck += nValue;

                if (numberToCheck >= minNaturalThreeDigitNumber && numberToCheck <= maxNaturalThreeDigitNumber)
                {
                    ++countNaturalThreeDigitNumber;
                    Console.Write("\t"+numberToCheck);
                }
            }

            Console.WriteLine("\nКоличество трехзначных натуральных чисел, которые кратны N:\t" + countNaturalThreeDigitNumber);
        }
    }
}
