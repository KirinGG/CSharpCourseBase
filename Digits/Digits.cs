using System;

namespace Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            int numberLength = Convert.ToString(number).Length;
            int i = 0;
            int digitsSum = 0;
            int maxDigit = 0;
            int oddDigitsSum = 0;

            while (i < numberLength)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 != 0)
                {
                    oddDigitsSum += digit;
                }

                maxDigit = (digit > maxDigit) ? digit : maxDigit;
                digitsSum += digit;
                i++;
            }

            Console.WriteLine("Сумма цифр = {0}; Сумма нечетных чисел = {1}; Максимальная цифра числа = {2}", digitsSum, oddDigitsSum, maxDigit);
        }
    }
}
