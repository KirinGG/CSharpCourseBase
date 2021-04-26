using System;

namespace Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            double number = Convert.ToDouble(Console.ReadLine());

            Range range = new Range(1, 5);

            if (range.IsInside(number))
            {
                Console.WriteLine("Число {0} входит в диапозон от {1} до {2}", number, range.From, range.To);
            }
            else
            {
                Console.WriteLine("Число {0} не входит в диапозон от {1} до {2}", number, range.From, range.To);
            }

            Console.WriteLine("Длина диапазона = {0}", range.GetLength());
        }
    }
}
