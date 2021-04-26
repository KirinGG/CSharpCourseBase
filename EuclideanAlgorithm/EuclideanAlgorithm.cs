using System;

namespace EuclideanAlgorithm
{
    class EuclideanAlgorithm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1;

            if (number1 == number2)
            {
                if (number1 == 0)
                {
                    Console.WriteLine("НОД не найден, т.к. оба числа = 0");
                }
                else
                {
                    Console.WriteLine("НОД({0},{1}) = {2}", number1, number2, result);
                }
            }
            else
            {
                int divisibleNumber = number1;
                int dividerNumber = number2;

                if (number2 == 0)
                {
                    divisibleNumber = number2;
                    dividerNumber = number1;
                }

                while (true)
                {
                    int divisionRemainder = divisibleNumber % dividerNumber;

                    if (divisionRemainder == 0)
                    {
                        break;
                    }

                    divisibleNumber = dividerNumber;
                    dividerNumber = divisionRemainder;
                }

                result = dividerNumber;
                Console.WriteLine("НОД({0},{1}) = {2}", number1, number2, result);
            }    
        }
    }
}
