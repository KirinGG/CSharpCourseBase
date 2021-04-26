using System;

namespace MinMax
{
    class MinMax
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число для поиска максимума(минимума):");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число для поиска максимума(минимума):");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int max1;
            int min1;

            if (number1 > number2)
            {
                max1 = number1;
                min1 = number2;
            }
            else
            {
                max1 = number2;
                min1 = number1;
            }

            Console.WriteLine("Вычислено с помощью условного оператора: Максимум = {0}; Минимум = {1}", max, min);

            int max2 = (number1 > number2) ? number1 : number2;
            int min2 = (number1 > number2) ? number2 : number1;

            Console.WriteLine("Вычислено с помощью тернарного оператора: Максимум = {0}; Минимум = {1}", max1, min1);
        }
    }
}
