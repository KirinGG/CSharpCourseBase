using System;

namespace SearchMaximumElement
{
    class SearchMaximumElement
    {
        static void Main(string[] args)
        {
            double[] realNumbers = { 1.0, 2.0, 5.0, 3.0 };
            Console.WriteLine("Максимальный элемент = {0}", GetMaximum(realNumbers));
        }

        public static double GetMaximum(double[] realNumbers)
        {
            double max = realNumbers[0];

            foreach (double e in realNumbers)
            {
                if (e > max)
                {
                    max = e;
                }
            }

            return max;
        }
    }
}
