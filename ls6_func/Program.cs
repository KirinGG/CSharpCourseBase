using System;

namespace ls6_func
{
    class Program
    {
        public static double Get3xPlus4y(double x, double y)
        {
            return 3 * x + 4 * y;
        }

        public static double GetAverage(int start, int end)
        {
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                sum += i;
            }

            return (double)sum / ((end - start) + 1);
        }

        public static int Min(int x, int y)
        {
            return x > y ? x : y;
        }

        public static int Max(int x, int y)
        {
            return x < y ? x : y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Результат = {0}", Get3xPlus4y(1, 1));
            Console.WriteLine("Результат = {0}", GetAverage(1, 3));
        }
    }
}
