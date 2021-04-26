using System;

/*
Распечатать числа от 1 до 100 при помощи цикла while, но выводить по 10 чисел в строке, дальше делать перевод строки
• 1 2 3 4 5 6 7 8 9 10
11 12 13 14 15 16 17 18 19 20
…
• Сложная версия задачи:
• Выводить числа ровно, чтобы они были друг под другом. Использовать возможности Write/WriteLine
• Возможность задать начальное и конечное число, и по сколько чисел в строке выводить
*/

namespace OutputNumbersToString
{
    class OutputNumbersToString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное число:");
            int beginRangeNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конечное число:");
            int endRangeNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество чисел в строке:");
            int numbersCountInLine = Convert.ToInt32(Console.ReadLine());

            int i = beginRangeNumber;
            string formatString = "{0," + (Convert.ToString(endRangeNumber).Length + 1) + "}";
            int numbersCount = 1;

            while (i <= endRangeNumber)
            {
                Console.Write(formatString, i);

                if (numbersCount % numbersCountInLine == 0)
                {
                    Console.WriteLine();
                }

                numbersCount++;
                i++;
            }
        }
    }
}
