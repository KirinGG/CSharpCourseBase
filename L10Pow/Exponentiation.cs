using System;

namespace Exponentiation
{
    class Exponentiation
    {
        static void Main(string[] args)
        {
            int[] powers = { 0, 1, 2, 3, 4, 5 };     
            int number = 2;

            Console.WriteLine("Рекурсивный алгоритм:");

            foreach (int e in powers)
            {
                Console.WriteLine("{0} в степени {1} = {2}",number, e, RaiseNumberToPowerRecursively(number, e));
            }

            Console.WriteLine("Обычный алгоритм:");

            foreach (int e in powers)
            {
                Console.WriteLine("{0} в степени {1} = {2}", number, e, RaiseNumberToPower(number, e));
            }
        }

        public static int RaiseNumberToPowerRecursively(int number, int power)
        {
            if (power == 0)
            {
                return 1;
            }

            return number * RaiseNumberToPower(number, power - 1);
        }

        public static int RaiseNumberToPower(int number, int power)
        {
            int result = 1;

            for(int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
