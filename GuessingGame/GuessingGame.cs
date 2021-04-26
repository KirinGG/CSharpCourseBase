using System;

namespace GuessingGame
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int hiddenNumber = random.Next(100) + 1;
            int attemptsCount = 0;

            for (; ; )
            {
                Console.WriteLine("Введите загаданное число:");
                int number = Convert.ToInt32(Console.ReadLine());

                attemptsCount++;

                if (number == hiddenNumber)
                {
                    Console.WriteLine("Вы отгадали с {0}й попытки! Загаданное число - {1}.", attemptsCount, hiddenNumber);
                    break;
                }

                if (number > hiddenNumber)
                {
                    Console.WriteLine("Введенное число - {0}, больше загаданного!", number);
                }
                else
                {
                    Console.WriteLine("Введенное число - {0}, меньше загаданного!", number);
                }
            }
        }
    }
}
