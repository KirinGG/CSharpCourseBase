using System;

namespace SeriesSum
{
    class SeriesSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел в ряду:");
            int seriesLength = Convert.ToInt32(Console.ReadLine());
            
            int i = 0;
            int seriesSum = 0;

            while (i <= seriesLength)
            {
                if (i % 2 == 0)
                {
                    seriesSum -= (int)Math.Pow(i, 2);
                }
                else
                {
                    seriesSum += (int)Math.Pow(i, 2);
                }

                i++;
            }

            Console.WriteLine("Сумма чисел ряда: {0}", seriesSum);
        }
    }
}
